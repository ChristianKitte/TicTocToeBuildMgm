using System;
using System.ComponentModel.Design;
using System.Security.Cryptography.X509Certificates;
using TicTocLib;

/// <summary>
/// Modul Verfahren und Werkzeuge moderner Softwaretechnik im WS 20/21
/// Einsendeaufgabe CCD (Clean Code Developer)
/// </summary>
namespace TicTocToe
{
    /// <summary>
    /// Programm TicTacToe - viel Spass dabei
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Spiel aktuellesSpiel = new Spiel();
            aktuellesSpiel.StarteSpiel();
        }
     
        public class Spiel
        {
            private Spielfeld spielfeld = new Spielfeld();

            public Spiel()
            {
            }

            public void StarteSpiel()
            {
                Console.WriteLine("Lass uns TikTakToe spielen!");
                Console.WriteLine("Spieler 1 (O), Spieler 2 (X)");

                ausgabe();

                Spieler aktuellerSpieler = Spieler.Spieler1;

                while (spielfeld.GibGewinnerZurück == Spieler.Undefiniert)
                {
                    eingabe(aktuellerSpieler);

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
                        Console.WriteLine("Gewinner " + spielfeld.GibGewinnerZurück.ToString());
                    }
                }
            }


            private void eingabe(Spieler aktuellerSpieler)
            {
                Console.WriteLine(aktuellerSpieler.ToString());

                string aktuelleZeile = Console.ReadLine();
                string erstesZeichen = aktuelleZeile[0].ToString();
                string zweitesZeichen = aktuelleZeile[1].ToString();

                Feld ausgewähltesFeld = EingabeAuswerten(erstesZeichen, zweitesZeichen);

                Spielzug ausgewählerSpielzug = new Spielzug(aktuellerSpieler, ausgewähltesFeld);
                spielfeld.spielzugHinzufügen(ausgewählerSpielzug);

                ausgabe();

                return;
            }

            public TicTocLib.Feld EingabeAuswerten(string erster, string zweiter)
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

            public void ausgabe()
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

            public String konvertiereSpielerInSymbol(Feld feld)
            {
                Spieler spieler = spielfeld.GibSpielerDesFeldesZurück(feld);
                if (spieler == Spieler.Spieler1) return "X";
                if (spieler == Spieler.Spieler2) return "O";

                return " ";
            }
        }
    }
}