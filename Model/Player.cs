﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe.Model
{
    internal class Player
    {
        public string Name { get; }
        public char Symbol { get; }
        public Player(string name, char symbol)
        {
            Name = name;
            Symbol = symbol;
        }
    }
}