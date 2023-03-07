using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess;

internal class Figure
{
    public string Item;
    public string Name;
    public int x;
    public int y;
    //{
    //    whiteKing = '\u2654',
    //    whiteQueen = '\u2655',
    //    whiteRook = '\u2656',
    //    whiteBishop = '\u2657',
    //    whiteKnight = '\u2658',
    //    whitePawn = '\u2659',
    //    blackKing = '\u265A',
    //    blackQueen = '\u265B',
    //    blackRook = '\u265C',
    //    blackBishop = '\u265D',
    //    blackKnight = '\u265E',
    //    blackPawn = '\u265F'
    //}
    
    public Figure(string Item, string Name,int x, int y)
    {
        this.Item = " &";
        this.Name = "name";
        this.x = x;
        this.y = y;
    }


    List<Figure> myFigures = new List<Figure>();
}
