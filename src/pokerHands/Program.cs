﻿using System;
using System.Collections.Generic;

namespace pokerHands
{
    class Program
    {
        static void Main(string[] args)
        {

            GameMachine gm = new GameMachine("player1", "player2");

            System.Console.WriteLine(gm.DealCards());
        
        }
    }
}
