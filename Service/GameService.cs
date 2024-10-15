using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacToe.Model;

namespace TicTacToe.Service
{
    internal class GameService
    {
        public static void MakeMove(int position , char symbol , Board board)
        {
            board.UpdateBoard(position, symbol);
        }
        public static bool CheckWin(Board board , char symbol)
        {
            return board.CheckWin(symbol);  
        }
    }
}