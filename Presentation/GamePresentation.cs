using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacToe.Controller;
using TicTacToe.Model;

namespace TicTacToe.Presentation
{
    internal class GamePresentation
    {
        public static void StartGame()
        {
            GameManager.InitializeGame();
            int movesCount = 0;
            bool gameWon = false;

            while (true)
            {
                Console.Clear();
                GameManager.DisplayBoard();
                GameManager.PlayerMove();
                movesCount++;
                gameWon = GameManager.CheckWin();
                if (gameWon)
                {
                    Console.Clear();
                    GameManager.DisplayBoard(); 
                    Console.WriteLine($"{GameManager.CurrentPlayer.Name} Wins!");
                    break;
                }
                if (movesCount == 9)
                {
                    Console.Clear();
                    GameManager.DisplayBoard();
                    Console.WriteLine("Draw!");
                    break;
                }
                GameManager.SwitchPlayer();
            }
        }
        public static string GetPlayerName(int playerName)
        {
            Console.WriteLine($"Enter Player Name {playerName} :");
            return Console.ReadLine();
        }
        public static int GetPlayerMove(Player currentPlayer)
        {
            int choice;
            bool validInput = false;
            do
            {
                Console.WriteLine($"{currentPlayer.Name} ({currentPlayer.Symbol}), Enter your move (1-9): ");
                validInput = int.TryParse(Console.ReadLine(), out choice) && choice >= 1 && choice <= 9 &&
                             GameManager.IsPositionAvailable(choice);

                if (!validInput)
                    Console.WriteLine("Invalid move! Please try again.");
            } while (!validInput);
            return choice;
        }
    }
}