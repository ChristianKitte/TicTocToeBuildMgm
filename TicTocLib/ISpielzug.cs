using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTocLib
{
    /// <summary>
    /// Definiert einen Spielzug
    /// </summary>
    public interface ISpielzug
    {
        /// <summary>
        /// Der setzende Spieler
        /// </summary>
        public Spieler SetzenderSpieler { get; }

        /// <summary>
        /// Das gesetzte Feld
        /// </summary>
        public Feld GesetztesFeld { get; }
    }
}
