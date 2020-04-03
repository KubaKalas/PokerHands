using System.Collections.Generic;
using System.Linq;

namespace pokerHands
{

    public class GameMachine
    {

        Player player1;
        Player player2;
        private List<Card> player1Cards;
        private List<Card> player2Cards;
        public List<Card> deck {get;set;}
        FileReader fileReader;

        
        public GameMachine(string player1Name, string player2Name)
        {

            fileReader = new FileReader();
            player1 = new Player(player1Name);
            player2 = new Player(player2Name);
            player1Cards = new List<Card>();
            player2Cards = new List<Card>();
            deck = fileReader.ReturnDeck();
            
        }

        public void addPoint(Player player)
        {   
            
        }

        public void ClearPlayerCards()
        {
            player1Cards.Clear();
            player2Cards.Clear();

        }
        public void DealCards()
        {
            for(int i = 0; i < deck.Count; i+=10)
            {
                player1Cards = deck.Take(5).ToList();
                //player2Cards = deck.Skip(5).Take(5).ToList();

                System.Console.WriteLine(CheckForOnePair(player1Cards));

            }
            
        }


        public void EvaluateCards(List<Card> p1C, List<Card> p2C)
        {

        }
        /*
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

            

        }

        public bool CheckForOnePair(List<Card> cards)
        {
            return cards.GroupBy(v => v.Value).Where(z => z.Count() == 2).Count() == 1;

        }

        public bool CheckForTwoPairs()
        {
            return player1Cards.GroupBy(v => v.Value).Where(z => z.Count() == 2).Count() == 2;
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





















