using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTocLib;

namespace TicTocToe
{
    /// <summary>
    /// Übernimmt die Eingabe aus der Konsole und ordnet sie dem zugehörigen Feld zu
    /// </summary>
    public class KonsolenEingabe
    {
        /// <summary>
        /// Liest zwei Zeichen ein und ordnet sie einem Feld zu
        /// </summary>
        /// <param name="aktuellerSpieler">Der aktuelle Spieler</param>
        /// <returns>Eine Instanz vom Typ Spielzug</returns>
        public Spielzug LeseEingabe(Spieler aktuellerSpieler)
        {
            Konsolenwerte wert = new Konsolenwerte();
            Console.WriteLine(aktuellerSpieler.ToString());

            Feld ausgewähltesFeld = Feld.Ungültig;

            while (ausgewähltesFeld == Feld.Ungültig)
            {
                string aktuelleZeile = Console.ReadLine();
                string erstesZeichen = aktuelleZeile[0].ToString();
                string zweitesZeichen = aktuelleZeile[1].ToString();

                ausgewähltesFeld = EingabeAuswerten(erstesZeichen.Trim().ToLower(), zweitesZeichen.Trim().ToLower());

                if (ausgewähltesFeld == Feld.Ungültig)
                {
                    Console.WriteLine(wert.ungültigeEingabe);
                }
            }

            Spielzug ausgewählerSpielzug = new Spielzug(aktuellerSpieler, ausgewähltesFeld);
            return ausgewählerSpielzug;
        }

        /// <summary>
        /// Wertet die Eingabe aus
        /// </summary>
        /// <param name="erster">Das erste übergebene Zeichen</param>
        /// <param name="zweiter">Das zweite übergebene Zeichen</param>
        /// <returns>Gibt ein Wert der Enumeration Feld zurück</returns>
        private TicTocLib.Feld EingabeAuswerten(string erster, string zweiter)
        {
            Konsolenwerte wert=new Konsolenwerte();

            Feld erkanntesEingabefeld = Feld.Ungültig;
            if (erster != wert.A && erster != wert.B && erster != wert.C) return erkanntesEingabefeld;
            if (zweiter != wert.EINS && zweiter != wert.ZWEI && zweiter != wert.DREI) return erkanntesEingabefeld;

            if (erster == wert.A)
            {
                if (zweiter == wert.EINS)
                {
                    erkanntesEingabefeld = Feld.A1;
                }
                else if (zweiter == wert.ZWEI)
                {
                    erkanntesEingabefeld = Feld.A2;
                }
                else if (zweiter == wert.DREI)
                {
                    erkanntesEingabefeld = Feld.A3;
                }
            }

            else if (erster == wert.B)
            {
                if (zweiter == wert.EINS)
                {
                    erkanntesEingabefeld = Feld.B1;
                }
                else if (zweiter == wert.ZWEI)
                {
                    erkanntesEingabefeld = Feld.B2;
                }
                else if (zweiter == wert.DREI)
                {
                    erkanntesEingabefeld = Feld.B3;
                }
            }

            else if (erster == wert.C)
            {
                if (zweiter == wert.EINS)
                {
                    erkanntesEingabefeld = Feld.C1;
                }
                else if (zweiter == wert.ZWEI)
                {
                    erkanntesEingabefeld = Feld.C2;
                }
                else if (zweiter == wert.DREI)
                {
                    erkanntesEingabefeld = Feld.C3;
                }
            }

            return erkanntesEingabefeld;
        }
    }
}