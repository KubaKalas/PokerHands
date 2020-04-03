using System;
using System.Collections.Generic;
using System.IO;

namespace pokerHands
{

    public class FileReader
    {

        private List<Card> cards;
        
        public FileReader()
        {
            cards = new List<Card>();
            
        }

        public List<Card> ReadCards()
        {
            const string filePath = "/Users/jakubkalas/Desktop/C#/PokerHands/src/hands.txt";

            using(StreamReader sr = new StreamReader(filePath))
            {
                string txtLine;

                while((txtLine = sr.ReadLine()) != null)
                {
                    // Console.WriteLine(txtLine);
                    cards.Add(ReadCardFromTxtFile(txtLine));    
                }
            }
            return cards;
        }

        
        public Card ReadCardFromTxtFile(string txtLine)
        {

            Card card = new Card();
            string[] parts = txtLine.Split(" ");

            foreach(string s in parts)
            {
                System.Console.WriteLine(s);
            }

            string value = parts[0][0].ToString();
            string suit = parts[0][1].ToString();

          System.Console.WriteLine("Here 3");

          System.Console.WriteLine(value);

            switch(value)
            {
                case "2":
                    card.Value = Value.Two;
                    break;
                case "3":
                    card.Value = Value.Three;
                    break;
                case "4":
                    card.Value = Value.Four;
                    break;
                case "5":
                    card.Value = Value.Five;
                    break;    
                case "6":
                    card.Value = Value.Six;
                    break;
                case "7":
                    card.Value = Value.Seven;
                    break;
                case "8":
                    card.Value = Value.Eight;
                    break;
                case "9":
                    card.Value = Value.Nine;
                    break;
                case "T":
                    card.Value = Value.Ten;
                    break;        
                case "J":
                    card.Value = Value.Jack;
                    break;    
                case "Q":
                    card.Value = Value.Queen;
                    break;
                case "K":
                    card.Value = Value.King;
                    break;    
                case "A":
                    card.Value = Value.Ace;
                    break;
                default:
                    card.Value = Value.None;
                    break;
            }

            Console.WriteLine("Here");

            switch(suit)
            {
                case "S":
                    card.Suit = Suit.Spades;
                    break;
                case "D":
                    card.Suit = Suit.Diamonds;
                    break;
                case "C":
                    card.Suit = Suit.Clubs;
                    break;
                case "H":
                    card.Suit = Suit.Hearts;
                    break;
            }

             Console.WriteLine("Here 2");
            return card;
        }
    }
}