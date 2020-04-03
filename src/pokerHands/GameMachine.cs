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
            fileReader.ReadCards();
            deck = fileReader.ReturnDeck();

        }

        public void addPoint(Player player)
        {   
            
        }

        public void ClearPlayerCards()
        {
            player1Cards.Clear();
            //player2Cards.Clear();
        }


        public void CheckCards()
        {



        }
        public void DealCards()
        {
                for(int i = 0;i < 5; i++)
                {
                    player1Cards.Add(deck[i]);
                
                }
                    System.Console.WriteLine($"Checking for one pair {CheckForOnePair(player1Cards)}");
                    System.Console.WriteLine($"Checking for two paids {CheckForTwoPairs(player1Cards)}");

                    ClearPlayerCards();
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
        public int CheckForHighCard(List<Card> cards)
        {
            return (int)cards.Max(m => m.Value);
        }

        public bool CheckForOnePair(List<Card> cards)
        {
            return cards.GroupBy(v => v.Value).Where(z => (int)z.Count() == 2).Count() == 1;
        }

        public bool CheckForTwoPairs(List<Card> cards)
        {
            return cards.GroupBy(v => v.Value).Where(z => (int)z.Count() == 2).Count() == 2;
        }

        public bool CheckForThreeOfAKind(List<Card> cards)
        {
            return cards.GroupBy(v => v.Value).Where(z => z.Count() == 4).Any();
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

        public bool CheckForFourOfAKind(List<Card> cards)
        {

            return cards.GroupBy(v => v.Value).Where(z => z.Count() == 4).Any();

        }

        public void CheckForStraightFlush()
        {

        }

        public void CheckForRoyalFlush()
        {

        }

    }
}





















