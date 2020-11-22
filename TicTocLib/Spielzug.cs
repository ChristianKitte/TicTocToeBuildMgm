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
    public class Spielzug : ISpielzug
    {
        private Spieler spieler;
        private Feld feld;

        /// <summary>
        /// Der Konstruktor
        /// </summary>
        /// <param name="spieler">Der setzende Spieler</param>
        /// <param name="feld">Das gesetzte Feld</param>
        public Spielzug(Spieler spieler, Feld feld)
        {
            this.spieler = spieler;
            this.feld = feld;
        }

        /// <summary>
        /// Der setzende Spieler
        /// </summary>
        public Spieler SetzenderSpieler {
            get
            {
                return this.spieler;
            }
        }

        /// <summary>
        /// Das gesetzte Feld
        /// </summary>
        public Feld GesetztesFeld {
            get
            {
                return this.feld;
            }
        }
    }
}