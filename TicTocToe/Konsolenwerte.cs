using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTocToe
{
    /// <summary>
    /// Liefert Werte zur Ausgabe und Eingabe mit der Konsole um magische Nummern vermeiden
    /// </summary>
    public struct Konsolenwerte
    {
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



        public String gewinntext
        {
            get { return "Der Gewinner ist"; }
        }
        public String begrüssungstext1
        {
            get { return "Lass uns TikTakToe spielen!"; }
        }
        public String begrüssungstext2
        {
            get { return "Spieler 1 (X), Spieler 2 (O)"; }
        }
        public String spieler1Symbol
        {
            get { return "X"; }
        }
        public String spieler2Symbol
        {
            get { return "O"; }
        }
        public String ungültigeEingabe
        {
            get { return "Bitte geben Sie nur die Zeichenfolgen A1 bis A3, B1 bis B3 und C1 bis C3 ein"; }
        }
        public String spielfeldTrennlinie
        {
            get { return "-|-|-|-"; }
        }
    }
}