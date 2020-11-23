using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTocLib
{
    /// <summary>
    /// Ein Objekt, dass zu einer Instanz vom Typ Feld ein Objekt vom Typ Spieler zurückliefern kann
    /// </summary>
    public interface ISpielerZuFeldZuordnung
    {
        /// <summary>
        /// Gibt den Spieler zurück, der das übergebene Feld gestzt hat
        /// </summary>
        /// <param name="feld">Das gesetzte Feld</param>
        /// <returns></returns>
        Spieler GibSpielerDesFeldesZurück(Feld feld);
    }
}
