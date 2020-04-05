using System;
using System.Collections.Generic;
using pokerHands;
using Xunit;

namespace test
{
    public class UnitTest1
    {

        public List<Card> GetCard(string hand)
        {
            FileReader fr = new FileReader();
            fr.ReadCardFromTxtFile(hand);
            return fr.ReturnDeck();
        }

        [Fact]
        public void TestForRoyalFlush()
        {
            string hand = "TC JC QC KC AC";
            GameMachine gm = new GameMachine("player1","player2");
            List<Card> cards = GetCard(hand);


            bool expected = true;
            bool actual = gm.CheckForRoyalFlush(cards);


            Assert.Equal(expected, actual);

        }

        
        [Fact]
        public void TestForStraightFlush()
        {
            string hand = "5H 6H 7H 8H 9H";
            GameMachine gm = new GameMachine("player1","player2");
            List<Card> cards = GetCard(hand);


            bool expected = true;
            bool actual = gm.CheckForStraightFlush(cards);


            Assert.Equal(expected, actual);

        }

        
        [Fact]
        public void TestForFourOfAKind()
        {
            string hand = "5C 5S 5H 5D 7H";
            GameMachine gm = new GameMachine("player1","player2");
            List<Card> cards = GetCard(hand);


            bool expected = true;
            bool actual = gm.CheckForFourOfAKind(cards);


            Assert.Equal(expected, actual);
        }

        
        [Fact]
        public void TestForFullHouse()
        {
            string hand = "3C 3H 3S 2S 2H";
            GameMachine gm = new GameMachine("player1","player2");
            List<Card> cards = GetCard(hand);


            bool expected = true;
            bool actual = gm.CheckForFullHouse(cards);


            Assert.Equal(expected, actual);

        }

        
        [Fact]
        public void TestForFlush()
        {
            string hand = "2H 3H 5H 2H 7H";
            GameMachine gm = new GameMachine("player1","player2");
            List<Card> cards = GetCard(hand);


            bool expected = true;
            bool actual = gm.CheckForFlush(cards);


            Assert.Equal(expected, actual);
        }

        
        [Fact]
        public void TestForStraight()
        {
            string hand = "TH 9S 8D 7S 6C"; 
            GameMachine gm = new GameMachine("player1","player2");
            List<Card> cards = GetCard(hand);


            bool expected = true;
            bool actual = gm.CheckForStraight(cards);


            Assert.Equal(expected, actual);

        }

        
        [Fact]
        public void TestForThreeOfAKind()
        {
            string hand = "3C 3H 3S 7H 8S";
            GameMachine gm = new GameMachine("player1","player2");
            List<Card> cards = GetCard(hand);


            bool expected = true;
            bool actual = gm.CheckForThreeOfAKind(cards);


            Assert.Equal(expected, actual);
        }
        
        [Fact]
        public void TestForTwoPairs()
        {
            string hand = "2H 2C 4H 4S 7H";
            GameMachine gm = new GameMachine("player1","player2");
            List<Card> cards = GetCard(hand);


            bool expected = true;
            bool actual = gm.CheckForTwoPairs(cards);


            Assert.Equal(expected, actual);
        }

        
        [Fact]
        public void TestForOnePair()
        {
            string hand = "2H 2C 5H 7H TC";
            GameMachine gm = new GameMachine("player1","player2");
            List<Card> cards = GetCard(hand);


            bool expected = true;
            bool actual = gm.CheckForOnePair(cards);


            Assert.Equal(expected, actual);
        }

    
    }
}
