using System.Collections.Generic;
using System.Linq;

namespace pokerHands
{

    public class GameMachine
    {

        private Player player1;
        private Player player2;
        private List<Card> player1Cards;
        private List<Card> player2Cards;
        private List<Card> deck;
        FileReader fileReader;
        Card card = new Card();

        public GameMachine(string player1Name, string player2Name)
        {

            fileReader = new FileReader();

            player1 = new Player(player1Name);
            player2 = new Player(player2Name);

            player1Cards = new List<Card>();
            player2Cards = new List<Card>();
            deck = new List<Card>();

            
           // card.value = (int)Value.Four;

        }

        public void addPoint(Player player)
        {   

            System.Console.WriteLine($"{nameof(player)} won");
            player.wins++;
            
        }
        public void ClearCards()
        {
            player1Cards.Clear();
            player2Cards.Clear();
        }

        public void AddCardsToDeck()
        {

        }










/*
        public void dealCards()
        {
             deck = fileReader.ReturnHands();

            for(int i = 0; i < deck.Count; i++)
            {
                player1Cards = deck.
            }
        }

        public void EvaluateCards(List<Card> p1C, List<Card> p2C)
        {

        }

        methods for checking all the possible cards a player may have
        1.High Card
        2. One Pairs
        3. Two Pairs
        4. Three of a kind
        5. Straight
        6. Flush
        7. Full House
        8. Four of a kind
        9. Straight Flush
        10.Royal Flush
        */
        
        public void CheckForHighCard(List<Card> cards)
        {

            if(cards.Count >= 0 && cards.Count <=5)
            {
            
            }

        }

        public void CheckForOnePair()
        {


        }

        public void CheckForTwoPairs()
        {

        }

        public void CheckForThreeOfAKind()
        {

        }

        public void CheckForStraight()
        {

        }

        public void CheckForFlush()
        {

        }

        public void CheckForFullHouse()
        {

        }

        public void CheckForFourOfAKind()
        {


        }

        public void CheckForStraightFlush()
        {

        }

        public void CheckForRoyalFlush()
        {

        }

    }
}





















