using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTocLib;

namespace TicTocToe
{
    /// <summary>
    /// Übernimmt die Ausgabe des Spielfeldes in eine Konsole
    /// </summary>
    public class KonsolenAusgabe
    {
        private ISpielerZuFeldZuordnung spielerZuFeldZuordnung = null;

        /// <summary>
        /// Der Konstruktor
        /// </summary>
        /// <param name="spielerZuFeldZuordnung">Eine Instanz vom Typ ISpielerZuFeldZuordnung </param>
        public KonsolenAusgabe(ISpielerZuFeldZuordnung spielerZuFeldZuordnung)
        {
            this.spielerZuFeldZuordnung = spielerZuFeldZuordnung;
        }

        /// <summary>
        /// Gibt das Spiel in die Konsole aus
        /// </summary>
        public void SpielInKonsoleAusgeben()
        {
            Console.Clear();

            string a1 = konvertiereSpielerInSymbol(Feld.A1);
            string a2 = konvertiereSpielerInSymbol(Feld.A2);
            string a3 = konvertiereSpielerInSymbol(Feld.A3);
            string b1 = konvertiereSpielerInSymbol(Feld.B1);
            string b2 = konvertiereSpielerInSymbol(Feld.B2);
            string b3 = konvertiereSpielerInSymbol(Feld.B3);
            string c1 = konvertiereSpielerInSymbol(Feld.C1);
            string c2 = konvertiereSpielerInSymbol(Feld.C2);
            string c3 = konvertiereSpielerInSymbol(Feld.C3);

            Console.WriteLine("Lass uns TikTakToe spielen!");
            Console.WriteLine("Spieler 1 (O), Spieler 2 (X)");
            Console.WriteLine();
            Console.WriteLine(String.Format("{0}|{1}|{2}|{3}", new[]
            {
                " ", "A", "B", "C"
            }));

            Console.WriteLine("-|-|-|-");
            Console.WriteLine(String.Format("{0}|{1}|{2}|{3}", new[]
            {
                "1", a1, b1, c1
            }));

            Console.WriteLine("-|-|-|-");
            Console.WriteLine(String.Format("{0}|{1}|{2}|{3}", new[]
            {
                "2", a2, b2, c2
            }));

            Console.WriteLine("-|-|-|-");
            Console.WriteLine(String.Format("{0}|{1}|{2}|{3}", new[]
            {
                "3", a3, b3, c3
            }));

            Console.WriteLine();
        }

        /// <summary>
        /// Bestimmt anhand des Spielers das in die Konsole zu verwendende Symbol (String)
        /// </summary>
        /// <param name="feld">Das Feld, welches ausgegeben werden soll</param>
        /// <returns>Ein String, der für den zum Feld gehörenden Spieler steht</returns>
        public String konvertiereSpielerInSymbol(Feld feld)
        {
            Spieler spieler = spielerZuFeldZuordnung.GibSpielerDesFeldesZurück(feld);
            if (spieler == Spieler.Spieler1) return "X";
            if (spieler == Spieler.Spieler2) return "O";

            return " ";
        }
    }
}
