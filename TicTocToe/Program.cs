using System;
using System.ComponentModel.Design;
using System.Security.Cryptography.X509Certificates;


/// <summary>
/// Modul Verfahren und Werkzeuge moderner Softwaretechnik im WS 20/21
/// Einsendeaufgabe CCD (Clean Code Developer)
/// </summary>
namespace TicTocToe
{
    /// <summary>
    /// Einstiegspunkt der Anwendung
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Spiel aktuellesSpiel = new Spiel();
            aktuellesSpiel.StarteSpiel();
        }
    }
}