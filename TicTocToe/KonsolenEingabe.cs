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
            Console.WriteLine(aktuellerSpieler.ToString());

            string aktuelleZeile = Console.ReadLine();
            string erstesZeichen = aktuelleZeile[0].ToString();
            string zweitesZeichen = aktuelleZeile[1].ToString();

            Feld ausgewähltesFeld = EingabeAuswerten(erstesZeichen, zweitesZeichen);

            Spielzug ausgewählerSpielzug = new Spielzug(aktuellerSpieler, ausgewähltesFeld);
            return ausgewählerSpielzug;
        }


        private TicTocLib.Feld EingabeAuswerten(string erster, string zweiter)
        {
            Feld erkanntesEingabefeld = Feld.Ungültig;
            if (erster != "a" && erster != "b" && erster != "c") return erkanntesEingabefeld;
            if (zweiter != "1" && zweiter != "2" && zweiter != "3") return erkanntesEingabefeld;
            if (erster == "a")
            {
                if (zweiter == "1")
                {
                    erkanntesEingabefeld = Feld.A1;
                }
                else if (zweiter == "2")
                {
                    erkanntesEingabefeld = Feld.A2;
                }
                else if (zweiter == "3")
                {
                    erkanntesEingabefeld = Feld.A3;
                }
            }

            else if (erster == "b")
            {
                if (zweiter == "1")
                {
                    erkanntesEingabefeld = Feld.B1;
                }
                else if (zweiter == "2")
                {
                    erkanntesEingabefeld = Feld.B2;
                }
                else if (zweiter == "3")
                {
                    erkanntesEingabefeld = Feld.B3;
                }
            }

            else if (erster == "c")
            {
                if (zweiter == "1")
                {
                    erkanntesEingabefeld = Feld.C1;
                }
                else if (zweiter == "2")
                {
                    erkanntesEingabefeld = Feld.C2;
                }
                else if (zweiter == "3")
                {
                    erkanntesEingabefeld = Feld.C3;
                }
            }

            return erkanntesEingabefeld;
        }
    }
}