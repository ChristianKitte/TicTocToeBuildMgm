using System;
using TicTocLib;

namespace TicTocToe.Konsolenhelfer
{
    public interface IKonsolenAusgabe
    {
        /// <summary>
        /// Gibt das Spiel in die Konsole aus
        /// </summary>
        void SpielInKonsoleAusgeben(ISpielerZuFeldZuordnung spielerZuFeldZuordnung);
    }
}