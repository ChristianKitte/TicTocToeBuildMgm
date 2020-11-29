using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTocToe.Konsolenhelfer
{
    /// <summary>
    /// Liefert Werte zur Ausgabe und Eingabe mit der Konsole um magische Nummern vermeiden und für Standardtexte
    /// </summary>
    public class Konsolenwerte:IKonsolenwerte
    {
        /// <summary>
        /// Der Konstruktor
        /// </summary>
        public Konsolenwerte()
        {
            
        }

        /// <summary>
        /// Definiert 1
        /// </summary>
        public String EINS
        {
            get { return "1"; }
        }

        /// <summary>
        /// Definiert 2
        /// </summary>
        public String ZWEI
        {
            get { return "2"; }
        }

        /// <summary>
        /// Definiert 3
        /// </summary>
        public String DREI
        {
            get { return "3"; }
        }

        /// <summary>
        /// Definiert A
        /// </summary>
        public String A
        {
            get { return "a"; }
        }

        /// <summary>
        /// Definiert B
        /// </summary>
        public String B
        {
            get { return "b"; }
        }

        /// <summary>
        /// Definiert C
        /// </summary>
        public String C
        {
            get { return "c"; }
        }

        /// <summary>
        /// Definiert den Gewinnertext
        /// </summary>
        public String gewinntext
        {
            get { return "Der Gewinner ist"; }
        }

        /// <summary>
        /// Definiert die erste Zeile des Begrüßungstext
        /// </summary>
        public String begrüssungstext1
        {
            get { return "Lass uns TikTakToe spielen!"; }
        }

        /// <summary>
        /// Definiert die zweite Zeile des Begrüßungstextes
        /// </summary>
        public String begrüssungstext2
        {
            get { return "Spieler 1 (X), Spieler 2 (O)"; }
        }

        /// <summary>
        /// Definiert das Symbol für den ersten Spieler
        /// </summary>
        public String spieler1Symbol
        {
            get { return "X"; }
        }

        /// <summary>
        /// Definiert das Symbol für den zweiten Spieler
        /// </summary>
        public String spieler2Symbol
        {
            get { return "O"; }
        }

        /// <summary>
        /// Definiert den Fehlertext für einen falschen Zug
        /// </summary>
        public String ungültigeEingabe
        {
            get { return "Bitte geben Sie nur die Zeichenfolgen A1 bis A3, B1 bis B3 und C1 bis C3 ein"; }
        }

        /// <summary>
        /// Definiert eine Trennlinie für die Consolenausgabe
        /// </summary>
        public String spielfeldTrennlinie
        {
            get { return "-|-|-|-"; }
        }
    }
}