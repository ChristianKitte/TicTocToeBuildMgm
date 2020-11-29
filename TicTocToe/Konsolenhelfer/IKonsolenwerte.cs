using System;

namespace TicTocToe.Konsolenhelfer
{
    public interface IKonsolenwerte
    {
        /// <summary>
        /// Definiert 1
        /// </summary>
        String EINS { get; }

        /// <summary>
        /// Definiert 2
        /// </summary>
        String ZWEI { get; }

        /// <summary>
        /// Definiert 3
        /// </summary>
        String DREI { get; }

        /// <summary>
        /// Definiert A
        /// </summary>
        String A { get; }

        /// <summary>
        /// Definiert B
        /// </summary>
        String B { get; }

        /// <summary>
        /// Definiert C
        /// </summary>
        String C { get; }

        /// <summary>
        /// Definiert den Gewinnertext
        /// </summary>
        String gewinntext { get; }

        /// <summary>
        /// Definiert die erste Zeile des Begrüßungstext
        /// </summary>
        String begrüssungstext1 { get; }

        /// <summary>
        /// Definiert die zweite Zeile des Begrüßungstextes
        /// </summary>
        String begrüssungstext2 { get; }

        /// <summary>
        /// Definiert das Symbol für den ersten Spieler
        /// </summary>
        String spieler1Symbol { get; }

        /// <summary>
        /// Definiert das Symbol für den zweiten Spieler
        /// </summary>
        String spieler2Symbol { get; }

        /// <summary>
        /// Definiert den Fehlertext für einen falschen Zug
        /// </summary>
        String ungültigeEingabe { get; }

        /// <summary>
        /// Definiert eine Trennlinie für die Consolenausgabe
        /// </summary>
        String spielfeldTrennlinie { get; }
    }
}