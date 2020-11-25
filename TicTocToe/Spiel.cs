using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTocLib;

namespace TicTocToe
{
    /// <summary>
    /// Die Klasse Spiel kapselt eine einzelne Partie des Spiels TikTacToe. Es wird direkt aus Main() aufgerufen
    /// </summary>
    public class Spiel
    {
        private Spielfeld spielfeld = new Spielfeld();
        private KonsolenEingabe konsolenEingabe = new KonsolenEingabe();
        private KonsolenAusgabe konsolenAusgabe = new KonsolenAusgabe();

        /// <summary>
        /// Der Konstruktor
        /// </summary>
        public Spiel()
        {
        }

        /// <summary>
        /// Beinhaltet die Kernfunktionalität des Spiels für die Ausführung innerhalb einer Konsole
        /// </summary>
        public void StarteSpiel()
        {
            Konsolenwerte wert = new Konsolenwerte();
            Console.WriteLine("Lass uns TikTakToe spielen!");
            Console.WriteLine("Spieler 1 (O), Spieler 2 (X)");

            konsolenAusgabe.SpielInKonsoleAusgeben(spielfeld);

            Spieler aktuellerSpieler = Spieler.Spieler1;

            while (spielfeld.GibGewinnerZurück == Spieler.Undefiniert)
            {
                Spielzug spielzug = konsolenEingabe.LeseEingabe(aktuellerSpieler);
                spielfeld.spielzugHinzufügen(spielzug);
                konsolenAusgabe.SpielInKonsoleAusgeben(spielfeld);

                if (spielfeld.GibGewinnerZurück == Spieler.Undefiniert)
                {
                    if (aktuellerSpieler == Spieler.Spieler1)
                    {
                        aktuellerSpieler = Spieler.Spieler2;
                    }
                    else if (aktuellerSpieler == Spieler.Spieler2)
                    {
                        aktuellerSpieler = Spieler.Spieler1;
                    }
                }
                else
                {
                    Console.WriteLine(string.Format("{0} {1}",
                        new object[] { wert.gewinntext, spielfeld.GibGewinnerZurück.ToString()}));
                }
            }
        }
    }
}