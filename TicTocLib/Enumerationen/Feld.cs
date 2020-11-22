using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTocLib
{
    /// <summary>
    /// Definiert die 9 verschiedenen Felder eines TikTacToe Spieles
    ///   A  B  C
    /// 1 x  x  x
    /// 2 x  x  x
    /// 3 x  x  x
    /// </summary>
    public enum Feld
    {
        Ungültig,
        A1,
        A2,
        A3,
        B1,
        B2,
        B3,
        C1,
        C2,
        C3
    }
}
