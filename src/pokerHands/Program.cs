using System;
using System.Collections.Generic;

namespace pokerHands
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello to Poker hands");

            //GameMachine gm = new GameMachine("player1", "player2");

            //gm.AddCardsToDeck();

            FileReader fr = new FileReader();
            List<Card> cards = fr.ReadCards();

            foreach(Card c in cards)
            {
                System.Console.Write(c.Value);
            }

            
        }
    }
}
