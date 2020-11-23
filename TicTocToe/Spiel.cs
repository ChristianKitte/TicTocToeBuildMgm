using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTocLib;

namespace TicTocToe
{
    public class Spiel
    {
        private Spielfeld spielfeld = new Spielfeld();
        private KonsolenEingabe konsolenEingabe = new KonsolenEingabe();
        private KonsolenAusgabe konsolenAusgabe = new KonsolenAusgabe();

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
                Spielzug spielzug = consolenEingabe.LeseEingabe(aktuellerSpieler);
                spielfeld.spielzugHinzufügen(spielzug);
                ausgabe();

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

    }
}