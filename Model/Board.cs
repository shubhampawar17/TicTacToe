﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe.Model
{
    internal class Board
    {
        private char[] positions;
        public Board()
        {
            positions = new char[] { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        }
        public void Display()
        {
            Console.WriteLine($" {positions[0]} | {positions[1]} | {positions[2]} ");
            Console.WriteLine("---|---|---");
            Console.WriteLine($" {positions[3]} | {positions[4]} | {positions[5]} ");
            Console.WriteLine("---|---|---");
            Console.WriteLine($" {positions[6]} | {positions[7]} | {positions[8]} ");
        }
        public void UpdateBoard(int position, char symbol)
        {
            positions[position - 1] = symbol;
        }
        public bool CheckWin(char symbol)
        {
            int[,] winCombinations = {
            { 0, 1, 2 }, { 3, 4, 5 }, { 6, 7, 8 }, 
            { 0, 3, 6 }, { 1, 4, 7 }, { 2, 5, 8 }, 
            { 0, 4, 8 }, { 2, 4, 6 }               
        };
            for (int i = 0; i < winCombinations.GetLength(0); i++)
            {
                if (positions[winCombinations[i, 0]] == symbol &&
                    positions[winCombinations[i, 1]] == symbol &&
                    positions[winCombinations[i, 2]] == symbol)
                {
                    return true;
                }
            }
            return false;
        }
        public bool IsPositionAvailable(int position)
        {
            return positions[position - 1] != 'X' && positions[position - 1] != 'O';
        }
    }
}