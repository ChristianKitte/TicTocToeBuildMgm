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
        /// <summary>
        /// Der Konstruktor
        /// </summary>
        public KonsolenAusgabe()
        {
        }

        /// <summary>
        /// Gibt das Spiel in die Konsole aus
        /// </summary>
        public void SpielInKonsoleAusgeben(ISpielerZuFeldZuordnung spielerZuFeldZuordnung)
        {
            Konsolenwerte wert = new Konsolenwerte();

            Console.Clear();

            string a1 = KonvertiereSpielerInSymbol(Feld.A1, spielerZuFeldZuordnung);
            string a2 = KonvertiereSpielerInSymbol(Feld.A2,spielerZuFeldZuordnung);
            string a3 = KonvertiereSpielerInSymbol(Feld.A3, spielerZuFeldZuordnung);
            string b1 = KonvertiereSpielerInSymbol(Feld.B1, spielerZuFeldZuordnung);
            string b2 = KonvertiereSpielerInSymbol(Feld.B2, spielerZuFeldZuordnung);
            string b3 = KonvertiereSpielerInSymbol(Feld.B3, spielerZuFeldZuordnung);
            string c1 = KonvertiereSpielerInSymbol(Feld.C1, spielerZuFeldZuordnung);
            string c2 = KonvertiereSpielerInSymbol(Feld.C2, spielerZuFeldZuordnung);
            string c3 = KonvertiereSpielerInSymbol(Feld.C3, spielerZuFeldZuordnung);

            Console.WriteLine(wert.begrüssungstext1);
            Console.WriteLine(wert.begrüssungstext2);
            Console.WriteLine();
            Console.WriteLine(String.Format("{0}|{1}|{2}|{3}", new[]
            {
                " ", wert.A.ToUpper(), wert.B.ToUpper(), wert.C.ToUpper()
            }));

            Console.WriteLine(wert.spielfeldTrennlinie);
            Console.WriteLine(String.Format("{0}|{1}|{2}|{3}", new[]
            {
                wert.EINS, a1, b1, c1
            }));

            Console.WriteLine(wert.spielfeldTrennlinie);
            Console.WriteLine(String.Format("{0}|{1}|{2}|{3}", new[]
            {
                wert.ZWEI, a2, b2, c2
            }));

            Console.WriteLine(wert.spielfeldTrennlinie);
            Console.WriteLine(String.Format("{0}|{1}|{2}|{3}", new[]
            {
                wert.DREI, a3, b3, c3
            }));

            Console.WriteLine();
        }

        /// <summary>
        /// Bestimmt anhand des Spielers das in die Konsole zu verwendende Symbol (String)
        /// </summary>
        /// <param name="feld">Das Feld, welches ausgegeben werden soll</param>
        /// <param name="spielerZuFeldZuordnung">Eine Instanz vom Typ ISpielerZuFeldZuordnung </param>
        /// <returns>Ein String, der für den zum Feld gehörenden Spieler steht</returns>
        public String KonvertiereSpielerInSymbol(Feld feld, ISpielerZuFeldZuordnung spielerZuFeldZuordnung)
        {
            Konsolenwerte wert = new Konsolenwerte();

            Spieler spieler = spielerZuFeldZuordnung.GibSpielerDesFeldesZurück(feld);
            if (spieler == Spieler.Spieler1) return wert.spieler1Symbol;
            if (spieler == Spieler.Spieler2) return wert.spieler2Symbol;

            return " ";
        }
    }
}
