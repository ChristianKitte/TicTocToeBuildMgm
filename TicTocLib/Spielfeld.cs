using System;
using System.ComponentModel.Design;

namespace TicTocLib
{
         /// <summary>
    /// Definiert ein TicTacToe Spielfeld
    /// </summary>
    public class Spielfeld : ISpielerZuFeldZuordnung
    {
        private Spieler a1 = Spieler.Undefiniert;
        private Spieler a2 = Spieler.Undefiniert;
        private Spieler a3 = Spieler.Undefiniert;
        private Spieler b1 = Spieler.Undefiniert;
        private Spieler b2 = Spieler.Undefiniert;
        private Spieler b3 = Spieler.Undefiniert;
        private Spieler c1 = Spieler.Undefiniert;
        private Spieler c2 = Spieler.Undefiniert;
        private Spieler c3 = Spieler.Undefiniert;

        /// <summary>
        /// Der Konstruktor
        /// </summary>
        public Spielfeld()
        {

        }

        /// <summary>
        /// Übernimmt den übergebenen Zug für den gebenden Spieler
        /// </summary>
        /// <param name="spielzug">Eine Instanz vom Typ Spielzug</param>
        public void spielzugHinzufügen(ISpielzug spielzug)
        {
            switch (spielzug.GesetztesFeld)
            {
                case Feld.A1:
                    this.a1 = spielzug.SetzenderSpieler;
                    break;
                case Feld.A2:
                    this.a2 = spielzug.SetzenderSpieler;
                    break;
                case Feld.A3:
                    this.a3 = spielzug.SetzenderSpieler;
                    break;
                case Feld.B1:
                    this.b1 = spielzug.SetzenderSpieler;
                    break;
                case Feld.B2:
                    this.b2 = spielzug.SetzenderSpieler;
                    break;
                case Feld.B3:
                    this.b3 = spielzug.SetzenderSpieler;
                    break;
                case Feld.C1:
                    this.c1 = spielzug.SetzenderSpieler;
                    break;
                case Feld.C2:
                    this.c2 = spielzug.SetzenderSpieler;
                    break;
                case Feld.C3:
                    this.c3 = spielzug.SetzenderSpieler;
                    break;
                default:
                    this.c3 = Spieler.Undefiniert;
                    break;
            }
        }

        /// <summary>
        /// Gibt den Gewinner oder Spieler.Unbestimmt zurück
        /// </summary>
        private Spieler ExistiertEinGewinner()
        {
            if (a1 == Spieler.Spieler1 && a2 == Spieler.Spieler1 && a3 == Spieler.Spieler1) return Spieler.Spieler1;
            if (b1 == Spieler.Spieler1 && b2 == Spieler.Spieler1 && b3 == Spieler.Spieler1) return Spieler.Spieler1;
            if (c1 == Spieler.Spieler1 && c2 == Spieler.Spieler1 && c3 == Spieler.Spieler1) return Spieler.Spieler1;

            if (a1 == Spieler.Spieler1 && b1 == Spieler.Spieler1 && c1 == Spieler.Spieler1) return Spieler.Spieler1;
            if (a2 == Spieler.Spieler1 && b2 == Spieler.Spieler1 && c2 == Spieler.Spieler1) return Spieler.Spieler1;
            if (a3 == Spieler.Spieler1 && b3 == Spieler.Spieler1 && c3 == Spieler.Spieler1) return Spieler.Spieler1;

            if (a1 == Spieler.Spieler1 && b2 == Spieler.Spieler1 && c3 == Spieler.Spieler1) return Spieler.Spieler1;
            if (c1 == Spieler.Spieler1 && b2 == Spieler.Spieler1 && a3 == Spieler.Spieler1) return Spieler.Spieler1;

            if (a1 == Spieler.Spieler2 && a2 == Spieler.Spieler2 && a3 == Spieler.Spieler2) return Spieler.Spieler2;
            if (b1 == Spieler.Spieler2 && b2 == Spieler.Spieler2 && b3 == Spieler.Spieler2) return Spieler.Spieler2;
            if (c1 == Spieler.Spieler2 && c2 == Spieler.Spieler2 && c3 == Spieler.Spieler2) return Spieler.Spieler2;

            if (a1 == Spieler.Spieler2 && b1 == Spieler.Spieler2 && c1 == Spieler.Spieler2) return Spieler.Spieler2;
            if (a2 == Spieler.Spieler2 && b2 == Spieler.Spieler2 && c2 == Spieler.Spieler2) return Spieler.Spieler2;
            if (a3 == Spieler.Spieler2 && b3 == Spieler.Spieler2 && c3 == Spieler.Spieler2) return Spieler.Spieler2;

            if (a1 == Spieler.Spieler2 && b2 == Spieler.Spieler2 && c3 == Spieler.Spieler2) return Spieler.Spieler2;
            if (c1 == Spieler.Spieler2 && b2 == Spieler.Spieler2 && a3 == Spieler.Spieler2) return Spieler.Spieler2;

            return Spieler.Undefiniert;
        }

        /// <summary>
        /// Gibt den Gewinner oder Spieler.Unbestimmt zurück
        /// </summary>
        public Spieler GibGewinnerZurück {
            get
            {
                return ExistiertEinGewinner();
            }
        }

        /// <summary>
        /// Gibt den Spieler zurück, der das übergebene Feld gestzt hat
        /// </summary>
        /// <param name="feld">Das gesetzte Feld</param>
        /// <returns></returns>
        public Spieler GibSpielerDesFeldesZurück(Feld feld)
        {
            Spieler spieler;

            switch (feld)
            {
                case Feld.A1:
                    spieler = a1;
                    break;
                case Feld.A2:
                    spieler = a2;
                    break;
                case Feld.A3:
                    spieler = a3;
                    break;
                case Feld.B1:
                    spieler = b1;
                    break;
                case Feld.B2:
                    spieler = b2;
                    break;
                case Feld.B3:
                    spieler = b3;
                    break;
                case Feld.C1:
                    spieler = c1;
                    break;
                case Feld.C2:
                    spieler = c2;
                    break;
                case Feld.C3:
                    spieler = c3;
                    break;
                default:
                    spieler = Spieler.Undefiniert;
                    break;
            }

            return spieler;
        }
    }
}
