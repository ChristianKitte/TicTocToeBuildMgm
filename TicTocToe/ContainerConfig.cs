using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using TicTocToe.Konsolenhelfer;

namespace TicTocToe
{
    /// <summary>
    /// Kapselt die Konfiguration des DI Containers
    /// </summary>
    public static class ContainerConfig
    {
        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<Application>().As<IApplication>();
            builder.RegisterType<Spiel>().As<ISpiel>();
            builder.RegisterType<Konsolenwerte>().As<IKonsolenwerte>();
            builder.RegisterType<KonsolenEingabe>().As<IKonsolenEingabe>();
            builder.RegisterType<KonsolenAusgabe>().As<IKonsolenAusgabe>();

            return builder.Build();
        }
    }
}