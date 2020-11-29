using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTocLib;

namespace TicTocToe.Konsolenhelfer
{
    /// <summary>
    /// Übernimmt die Eingabe aus der Konsole und ordnet sie dem zugehörigen Feld zu
    /// </summary>
    public class KonsolenEingabe : IKonsolenEingabe
    {
        private IKonsolenwerte konsolenWert;

        /// <summary>
        /// Der Konstruktor
        /// </summary>
        public KonsolenEingabe(IKonsolenwerte konsolenWert)
        {
            this.konsolenWert = konsolenWert;
        }

        /// <summary>
        /// Liest zwei Zeichen ein und ordnet sie einem Feld zu
        /// </summary>
        /// <param name="aktuellerSpieler">Der aktuelle Spieler</param>
        /// <returns>Eine Instanz vom Typ Spielzug</returns>
        public Spielzug LeseEingabe(Spieler aktuellerSpieler)
        {
            Console.WriteLine(aktuellerSpieler.ToString());

            Feld ausgewähltesFeld = Feld.Ungültig;

            while (ausgewähltesFeld == Feld.Ungültig)
            {
                string aktuelleZeile = Console.ReadLine() + "";

                string erstesZeichen = string.Empty;
                string zweitesZeichen = string.Empty;
                if (aktuelleZeile.Length == 2)
                {
                    erstesZeichen = aktuelleZeile[0].ToString();
                    zweitesZeichen = aktuelleZeile[1].ToString();
                }

                ausgewähltesFeld = EingabeAuswerten(erstesZeichen.Trim().ToLower(), zweitesZeichen.Trim().ToLower());

                if (ausgewähltesFeld == Feld.Ungültig)
                {
                    Console.WriteLine(konsolenWert.ungültigeEingabe);
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
            Feld erkanntesEingabefeld = Feld.Ungültig;
            if (erster != konsolenWert.A && erster != konsolenWert.B && erster != konsolenWert.C)
                return erkanntesEingabefeld;
            if (zweiter != konsolenWert.EINS && zweiter != konsolenWert.ZWEI && zweiter != konsolenWert.DREI)
                return erkanntesEingabefeld;

            if (erster == konsolenWert.A)
            {
                if (zweiter == konsolenWert.EINS)
                {
                    erkanntesEingabefeld = Feld.A1;
                }
                else if (zweiter == konsolenWert.ZWEI)
                {
                    erkanntesEingabefeld = Feld.A2;
                }
                else if (zweiter == konsolenWert.DREI)
                {
                    erkanntesEingabefeld = Feld.A3;
                }
            }

            else if (erster == konsolenWert.B)
            {
                if (zweiter == konsolenWert.EINS)
                {
                    erkanntesEingabefeld = Feld.B1;
                }
                else if (zweiter == konsolenWert.ZWEI)
                {
                    erkanntesEingabefeld = Feld.B2;
                }
                else if (zweiter == konsolenWert.DREI)
                {
                    erkanntesEingabefeld = Feld.B3;
                }
            }

            else if (erster == konsolenWert.C)
            {
                if (zweiter == konsolenWert.EINS)
                {
                    erkanntesEingabefeld = Feld.C1;
                }
                else if (zweiter == konsolenWert.ZWEI)
                {
                    erkanntesEingabefeld = Feld.C2;
                }
                else if (zweiter == konsolenWert.DREI)
                {
                    erkanntesEingabefeld = Feld.C3;
                }
            }

            return erkanntesEingabefeld;
        }
    }
}