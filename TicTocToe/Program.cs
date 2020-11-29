using System;
using System.ComponentModel.Design;
using System.Security.Cryptography.X509Certificates;
using Autofac;
using Autofac.Core;
using TicTocToe.Konsolenhelfer;
     
/// <summary>
/// Modul Verfahren und Werkzeuge moderner Softwaretechnik im WS 20/21
/// Einsendeaufgabe CCD (Clean Code Developer)
/// </summary>
namespace TicTocToe                                                                                                          
{
    /// <summary>
    /// Einstiegsklasse der Anwendung
    /// </summary>
    class Program
    {
        /// <summary>
        /// Einstiegspunkt der Anwendung
        /// </summary>
        /// <param name="args">Argumentenliste</param>
        static void Main(string[] args)
        {
            var container = ContainerConfig.Configure();

            using (var scope = container.BeginLifetimeScope())
            {
                var app = scope.Resolve<IApplication>();
                app.Run();
            }
        }
    }
}