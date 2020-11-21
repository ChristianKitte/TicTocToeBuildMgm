using System;
using System.ComponentModel.Design;
using System.Security.Cryptography.X509Certificates;

/// <summary>
/// Modul Verfahren und Werkzeuge moderner Softwaretechnik im WS 20/21
/// Einsendeaufgabe CCD (Clean Code Developer)
/// Schlecht geschriebener Basiscode
/// </summary>
namespace TicTocToe
{
    /// <summary>
    /// Programm TicTacToe - viel Spass dabei
    /// </summary>
    class Program
    {
        static int spieler = 1;
        static string a1 = " ";
        static string a2 = " ";
        static string a3 = " ";
        static string b1 = " ";
        static string b2 = " ";
        static string b3 = " ";
        static string c1 = " ";
        static string c2 = " ";
        static string c3 = " ";

        static void Main(string[] args)
        {
            Console.WriteLine("Lass uns TikTakToe spielen!");
            Console.WriteLine("Spieler 1 (O), Spieler 2 (X)");

            ausgabe();  //test

            spieler = 1;

            while (spieler != 0)
            {
                eingabe(spieler);
            }
        }

        static void eingabe(int s)
        {
            if (spieler == 1)
            {
                Console.WriteLine("Eingabe Spieler 1");

                string f = Console.ReadLine();
                string erster = f[0].ToString();
                string zweiter = f[1].ToString();

                if (erster != "a" && erster != "b" && erster != "c") return;
                if (zweiter != "1" && zweiter != "2" && zweiter != "3") return;

                if (erster == "a")
                {
                    if (zweiter == "1")
                    {
                        a1 = "O";
                    }
                    else if (zweiter == "2")
                    {
                        a2 = "O";
                    }
                    else if (zweiter == "3")
                    {
                        a3 = "O";
                    }
                }
                else if (erster == "b")
                {
                    if (zweiter == "1")
                    {
                        b1 = "O";
                    }
                    else if (zweiter == "2")
                    {
                        b2 = "O";
                    }
                    else if (zweiter == "3")
                    {
                        b3 = "O";
                    }
                }
                else if (erster == "c")
                {
                    if (zweiter == "1")
                    {
                        c1 = "O";
                    }
                    else if (zweiter == "2")
                    {
                        c2 = "O";
                    }
                    else if (zweiter == "3")
                    {
                        c3 = "O";
                    }
                }

                ausgabe();

                int g1 = test();
                if (g1 == 0)
                {
                    spieler = 2;
                    return;
                }
                else
                {
                    Console.WriteLine("Spieler 1 gewinnt");
                }
            }
            else
            {
                Console.WriteLine("Eingabe Spieler 2 ");

                string f = Console.ReadLine();
                string erster = f[0].ToString();
                string zweiter = f[1].ToString();

                if (erster != "a" && erster != "b" && erster != "c") return;
                if (zweiter != "1" && zweiter != "2" && zweiter != "3") return;

                if (erster == "a")
                {
                    if (zweiter == "1")
                    {
                        a1 = "X";
                    }
                    else if (zweiter == "2")
                    {
                        a2 = "X";
                    }
                    else if (zweiter == "3")
                    {
                        a3 = "X";
                    }
                }
                else if (erster == "b")
                {
                    if (zweiter == "1")
                    {
                        b1 = "X";
                    }
                    else if (zweiter == "2")
                    {
                        b2 = "X";
                    }
                    else if (zweiter == "3")
                    {
                        b3 = "X";
                    }
                }
                else if (erster == "c")
                {
                    if (zweiter == "1")
                    {
                        c1 = "X";
                    }
                    else if (zweiter == "2")
                    {
                        c2 = "X";
                    }
                    else if (zweiter == "3")
                    {
                        c3 = "X";
                    }
                }

                ausgabe();

                int g2 = test();
                if (g2 == 0)
                {
                    spieler = 1;
                    return;
                }
                else
                {
                    Console.WriteLine("Spieler 2 gewinnt");
                }
            }
        }

        static void ausgabe()
        {
            Console.Clear();

            Console.WriteLine("Lass uns TikTakToe spielen!");
            Console.WriteLine("Spieler 1 (O), Spieler 2 (X)");
            Console.WriteLine();

            Console.WriteLine(String.Format("{0}|{1}|{2}|{3}", new[] {" ", "A", "B", "C"}));
            Console.WriteLine("-|-|-|-");
            Console.WriteLine(String.Format("{0}|{1}|{2}|{3}", new[] {"1", a1, b1, c1}));
            Console.WriteLine("-|-|-|-");
            Console.WriteLine(String.Format("{0}|{1}|{2}|{3}", new[] {"2", a2, b2, c2}));
            Console.WriteLine("-|-|-|-");
            Console.WriteLine(String.Format("{0}|{1}|{2}|{3}", new[] {"3", a3, b3, c3}));
            Console.WriteLine();
        }

        static int test()
        {
            if (a1.Trim() == "O" && a2.Trim() == "O" && a3.Trim() == "O") return 1;
            if (b1.Trim() == "O" && b2.Trim() == "O" && b3.Trim() == "O") return 1;
            if (c1.Trim() == "O" && c2.Trim() == "O" && c3.Trim() == "O") return 1;
            if (a1.Trim() == "O" && b2.Trim() == "O" && c3.Trim() == "O") return 1;
            if (c1.Trim() == "O" && b2.Trim() == "O" && a3.Trim() == "O") return 1;

            if (a1.Trim() == "X" && a2.Trim() == "X" && a3.Trim() == "X") return 2;
            if (b1.Trim() == "X" && b2.Trim() == "X" && b3.Trim() == "X") return 2;
            if (c1.Trim() == "X" && c2.Trim() == "X" && c3.Trim() == "X") return 2;
            if (a1.Trim() == "X" && b2.Trim() == "X" && c3.Trim() == "X") return 2;
            if (c1.Trim() == "X" && b2.Trim() == "X" && a3.Trim() == "X") return 2;

            return 0;
        }
    }
}