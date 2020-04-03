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
        
        //reads the txt file line by line
        public void ReadCards()
        {
            const string filePath = "/Users/jakubkalas/Desktop/C#/PokerHands/src/hands.txt";

            using(StreamReader sr = new StreamReader(filePath))
            {
                string txtLine;

                while((txtLine = sr.ReadLine()) != null)
                {
                    //cards.Add
                    ReadCardFromTxtFile(txtLine);    
                }
            }
        }

        public List<Card> ReturnDeck() => cards;
    

        //receives the line of text and converts it to a Card type
        //sets the enum Value and Suit for Card type
        public void ReadCardFromTxtFile(string txtLine)
        {
            string[] parts = txtLine.Split(" ");
            foreach(string s in parts)
            {   
                Card card = new Card();
                string value = s[0].ToString();
                string suit = s[1].ToString();

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

                cards.Add(card);
            }
        }
    }
}