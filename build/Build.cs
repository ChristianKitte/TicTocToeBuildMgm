using System;
using System.Linq;
using Nuke.Common;
using Nuke.Common.CI;
using Nuke.Common.Execution;
using Nuke.Common.Git;
using Nuke.Common.IO;
using Nuke.Common.ProjectModel;
using Nuke.Common.Tooling;
using Nuke.Common.Tools.DotNet;
using Nuke.Common.Utilities.Collections;
using static Nuke.Common.EnvironmentInfo;
using static Nuke.Common.IO.FileSystemTasks;
using static Nuke.Common.IO.PathConstruction;
using static Nuke.Common.Tools.DotNet.DotNetTasks;

[CheckBuildProjectConfigurations]
[ShutdownDotNetAfterServerBuild]
class Build : NukeBuild
{
    /// Support plugins are available for:
    ///   - JetBrains ReSharper        https://nuke.build/resharper
    ///   - JetBrains Rider            https://nuke.build/rider
    ///   - Microsoft VisualStudio     https://nuke.build/visualstudio
    ///   - Microsoft VSCode           https://nuke.build/vscode
    public static int Main() => Execute<Build>(x => x.Deploy);

    [Parameter("Configuration to build - Default is 'Debug' (local) or 'Release' (server)")]
    readonly Configuration Configuration = IsLocalBuild ? Configuration.Debug : Configuration.Release;

    [Solution] readonly Solution Solution;

    [GitRepository] readonly GitRepository GitRepository;

    AbsolutePath SourceDirectory => RootDirectory / "src";
    AbsolutePath TestsDirectory => RootDirectory / "tests";
    AbsolutePath OutputDirectory => RootDirectory / "output";
    AbsolutePath TutorialDirectory => RootDirectory / "tutorial";
    AbsolutePath BinaryDirectory => RootDirectory / "TicTocToe" / "bin" / "Release" / "net5.0";

    Target Clean => _ => _
        .Executes(() =>
        {
            SourceDirectory.GlobDirectories("**/bin", "**/obj").ForEach(DeleteDirectory);
            TestsDirectory.GlobDirectories("**/bin", "**/obj").ForEach(DeleteDirectory);

            EnsureCleanDirectory(OutputDirectory);
        });

    Target Restore => _ => _
        .DependsOn(Clean)
        .Executes(() =>
        {
            DotNetRestore(s => s
                .SetProjectFile(Solution));
        });

    Target Compile => _ => _
        .DependsOn(Restore)
        .Executes(() =>
        {
            DotNetBuild(s => s
                .SetProjectFile(Solution)
                .SetConfiguration(Configuration)
                .EnableNoRestore());
        });

    Target Deploy => _ => _
        .DependsOn(Compile)
        .Executes(() =>
        {
            System.IO.File.Copy(TutorialDirectory + "\\tutorial.html", OutputDirectory + "\\tutorial.html");

            System.IO.File.Copy(BinaryDirectory + "\\TicTocToe.exe", OutputDirectory + "\\TicTocToe.exe");
            System.IO.File.Copy(BinaryDirectory + "\\TicTocToe.dll", OutputDirectory + "\\TicTocToe.dll");
            System.IO.File.Copy(BinaryDirectory + "\\TicTocToe.dll.config", OutputDirectory + "\\TicTocToe.dll.config");
            System.IO.File.Copy(BinaryDirectory + "\\TicTocToe.runtimeconfig.json", OutputDirectory + "\\TicTocToe.runtimeconfig.json");
            System.IO.File.Copy(BinaryDirectory + "\\TicTocLib.dll", OutputDirectory + "\\TicTocLib.dll");
            System.IO.File.Copy(BinaryDirectory + "\\Autofac.dll", OutputDirectory + "\\Autofac.dll");

        });
}