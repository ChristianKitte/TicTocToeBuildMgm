using TicTocLib;

namespace TicTocToe.Konsolenhelfer
{
    public interface IKonsolenEingabe
    {
        /// <summary>
        /// Liest zwei Zeichen ein und ordnet sie einem Feld zu
        /// </summary>
        /// <param name="aktuellerSpieler">Der aktuelle Spieler</param>
        /// <returns>Eine Instanz vom Typ Spielzug</returns>
        Spielzug LeseEingabe(Spieler aktuellerSpieler);
    }
}