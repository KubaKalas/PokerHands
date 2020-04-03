using System;
using System.Collections.Generic;

namespace pokerHands
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello to Poker hands");

            GameMachine gm = new GameMachine("player1", "player2");
            //gm.DealCards();
            FileReader fr = new FileReader();
            fr.ReadCards();

        
        }
    }
}
