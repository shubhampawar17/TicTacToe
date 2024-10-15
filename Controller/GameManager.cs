using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacToe.Model;
using TicTacToe.Presentation;
using TicTacToe.Service;

namespace TicTacToe.Controller
{
    internal class GameManager
    {
        public static Player CurrentPlayer { get; private set; }
        public static Player Player1 { get; private set; }
        public static Player Player2 { get; private set; }
        public static Board GameBoard;
        public static void InitializeGame()
        {
            //string player1Name = GamePresentation.GetPlayerName(1);
            //string player2Name = GamePresentation.GetPlayerName(2);
            //Player1 = new Player(player1Name, 'X');
            //Player2 = new Player(player2Name, 'O');
            Player1 = CreatePlayer(1, 'x');
            Player2 = CreatePlayer(2, 'O');
            CurrentPlayer = Player1;
            GameBoard = new Board();
        }
        private static Player CreatePlayer(int playNumber , char symbol)
        {
            string playerName = GamePresentation.GetPlayerName(playNumber); 
            return new Player(playerName, symbol);
        }
        public static void DisplayBoard()
        {
            GameBoard.Display();
        }
        public static void PlayerMove()
        {
            int position = GamePresentation.GetPlayerMove(CurrentPlayer);
            GameService.MakeMove(position, CurrentPlayer.Symbol, GameBoard);
        }
        public static bool CheckWin()
        {
            return GameService.CheckWin(GameBoard, CurrentPlayer.Symbol);
        }
        public static void SwitchPlayer()
        {
            CurrentPlayer = (CurrentPlayer == Player1) ? Player2 : Player1;
        }
        public static bool IsPositionAvailable(int position)
        {
            return GameBoard.IsPositionAvailable(position);
        }
    }
}