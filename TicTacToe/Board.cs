using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public class Board
    {
        public int[] BoardStatus { get; }

        public Board()
        {
            BoardStatus = new int[9];
            BoardStatus[0] = 0;
            BoardStatus[1] = 0;
            BoardStatus[2] = 0;
            BoardStatus[3] = 0;
            BoardStatus[4] = 0;
            BoardStatus[5] = 0;
            BoardStatus[6] = 0;
            BoardStatus[7] = 0;
            BoardStatus[8] = 0;
        }

        public void SelectSquare(int index, int player)
        {
            BoardStatus[index] = player;
        }

        public void DrawBoard()
        {
            Console.Write("  {0}  ", XOrO(1));
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("|");
            Console.Write("  {0}  ", XOrO(2));
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("|");
            Console.WriteLine("  {0}  ", XOrO(3));
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("_________________");
            Console.Write("  {0}  ", XOrO(4));
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("|");
            Console.Write("  {0}  ", XOrO(5));
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("|");
            Console.WriteLine("  {0}  ", XOrO(6));
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("_________________");
            Console.Write("  {0}  ", XOrO(7));
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("|");
            Console.Write("  {0}  ", XOrO(8));
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("|");
            Console.WriteLine("  {0}  ", XOrO(9));
        }

        private string XOrO(int index)
        {
            switch (BoardStatus[index - 1])
            {
                case 0:
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    return index.ToString();
                case 1:
                    Console.ForegroundColor = ConsoleColor.Red;
                    return "X";
                case 2:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    return "O";
                default:
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    return index.ToString();
            }

        }

        public int CheckIfWinOrDraw()
        {
            //line win
            if ((BoardStatus[0] != 0 && BoardStatus[1] != 0 && BoardStatus[2] != 0) && 
                BoardStatus[0] == BoardStatus[1] && BoardStatus[1] == BoardStatus[2])
            {
                return 1;
            }
            if ((BoardStatus[3] != 0 && BoardStatus[4] != 0 && BoardStatus[5] != 0) && 
                BoardStatus[3] == BoardStatus[4] && BoardStatus[4] == BoardStatus[5])
            {
                return 1;
            }
            if ((BoardStatus[6] != 0 && BoardStatus[7] != 0 && BoardStatus[8] != 0) && 
                BoardStatus[6] == BoardStatus[7] && BoardStatus[7] == BoardStatus[8])
            {
                return 1;
            }
            //column win
            if ((BoardStatus[0] != 0 && BoardStatus[3] != 0 && BoardStatus[6] != 0) && 
                BoardStatus[0] == BoardStatus[3] && BoardStatus[3] == BoardStatus[6])
            {
                return 1;
            }
            if ((BoardStatus[1] != 0 && BoardStatus[4] != 0 && BoardStatus[7] != 0) && 
                BoardStatus[1] == BoardStatus[4] && BoardStatus[4] == BoardStatus[7])
            {
                return 1;
            }
            if ((BoardStatus[2] != 0 && BoardStatus[5] != 0 && BoardStatus[8] != 0) && 
                BoardStatus[2] == BoardStatus[5] && BoardStatus[5] == BoardStatus[8])
            {
                return 1;
            }
            //diagonal win
            if ((BoardStatus[0] != 0 && BoardStatus[4] != 0 && BoardStatus[8] != 0) && 
                BoardStatus[0] == BoardStatus[4] && BoardStatus[4] == BoardStatus[8])
            {
                return 1;
            }
            if ((BoardStatus[2] != 0 && BoardStatus[4] != 0 && BoardStatus[6] != 0) && 
                BoardStatus[2] == BoardStatus[4] && BoardStatus[4] == BoardStatus[6])
            {
                return 1;
            }
            //draw
            if (BoardStatus.All(p => p != 0))
            {
                return -1;
            }
            return 0;
        }


    }
}
