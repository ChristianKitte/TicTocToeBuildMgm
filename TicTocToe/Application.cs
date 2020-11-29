using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTocToe
{
    /// <summary>
    /// Kapselt die Anwendung selbst (das Spiel)
    /// </summary>
    class Application : IApplication
    {
        private ISpiel _spiel;

        public Application(ISpiel spiel)
        {
            _spiel = spiel;
        }

        public void Run()
        {
            _spiel.StarteSpiel();
        }
    }
}