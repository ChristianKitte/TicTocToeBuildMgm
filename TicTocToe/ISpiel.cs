using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTocToe
{
    public interface ISpiel
    {
        /// <summary>
        /// Beinhaltet die Kernfunktionalität des Spiels für die Ausführung innerhalb einer Konsole
        /// </summary>
        void StarteSpiel();
    }
}
