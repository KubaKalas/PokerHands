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

        public void AddPoint(Player player)
        {   
            player.wins += 1;
        }

        public void ClearPlayerCards()
        {
            player1Cards.Clear();
            player2Cards.Clear();
        }

        public string DealCards()
        {
                //looping over the deck, each players is being dealt 5 cards each
                //index is incremented by 5
            for(int index = 0; index < deck.Count; index+=5)
            {
                //using the Linq Skip and Take to deal each player 5 card
                //first player initially skips zero cards and takes first 5
                //second player skips five card and take next 5 cards.
                player1Cards = deck.Skip(0 + index).Take(5 + index).ToList();
                player2Cards = deck.Skip(5 + index).Take(5 + index).ToList();

                AddPoint(EvaluateCards(player1Cards,player2Cards));

                ClearPlayerCards();
            }
            return player1.wins > player2.wins ? $"Player 1 won! \n With {player1.wins} wins" : $"Player 2 won! \n With {player2.wins} wins";
        }


        public Player EvaluateCards(List<Card> p1C, List<Card> p2C)
        {
            if(CheckForRoyalFlush(p1C) && CheckForRoyalFlush(p2C))
                if(CheckForHighCard(p1C) > CheckForHighCard(p2C))
                    return player1;
                else
                    return player2;
            else if(CheckForRoyalFlush(p1C) && !(CheckForRoyalFlush(p2C)))
                return player1;
            else if(!(CheckForRoyalFlush(p1C) && (CheckForRoyalFlush(p2C))))
                return player2;
            else if(CheckForStraightFlush(p1C) && CheckForStraightFlush(p2C))
                if(CheckForHighCard(p1C) > CheckForHighCard(p2C))
                    return player1;
                else
                    return player2;
            else if(CheckForStraightFlush(p1C) && !(CheckForStraightFlush(p2C)))
                return player1;
            else if(!(CheckForRoyalFlush(p1C) && (CheckForRoyalFlush(p2C))))
                return player2;
            else if(CheckForFourOfAKind(p1C) && CheckForFourOfAKind(p2C))
                if(CheckForHighCard(p1C) > CheckForHighCard(p2C))
                    return player1;
                else
                    return player2;
            else if(CheckForFourOfAKind(p1C) && !(CheckForFourOfAKind(p2C)))
                return player1;
            else if(!(CheckForRoyalFlush(p1C) && (CheckForRoyalFlush(p2C))))
                return player2;
            else if(CheckForFullHouse(p1C) && CheckForFullHouse(p2C))
                if(CheckForHighCard(p1C) > CheckForHighCard(p2C))
                    return player1;
                else
                    return player2;
            else if(CheckForFullHouse(p1C) && !(CheckForFullHouse(p2C)))
                return player1;
            else if(!(CheckForFullHouse(p1C) && (CheckForFullHouse(p2C))))
                return player2;           
            else if(CheckForFlush(p1C) && CheckForFlush(p2C))           
                if(CheckForHighCard(p1C) > CheckForHighCard(p2C))
                    return player1;
                else
                    return player2;
            else if(CheckForFlush(p1C) && !(CheckForFlush(p2C)))           
                return player1;
            else if(!(CheckForFlush(p1C) && (CheckForFlush(p2C))))           
                return player2;           
            else if(CheckForStraight(p1C) && CheckForStraight(p2C))          
                if(CheckForHighCard(p1C) > CheckForHighCard(p2C))
                    return player1;
                else
                    return player2;
            else if(CheckForStraight(p1C) && !(CheckForStraight(p2C)))        
                return player1;
            else if(!(CheckForStraight(p1C) && (CheckForStraight(p2C))))       
                return player2;           
            else if(CheckForThreeOfAKind(p1C) && CheckForThreeOfAKind(p2C))          
                if(CheckForHighCard(p1C) > CheckForHighCard(p2C))
                    return player1;
                else
                    return player2;
            else if(CheckForThreeOfAKind(p1C) && !(CheckForThreeOfAKind(p2C)))          
                return player1;
            else if(!(CheckForThreeOfAKind(p1C) && (CheckForThreeOfAKind(p2C))))         
                return player2;          
            else if(CheckForTwoPairs(p1C) && CheckForTwoPairs(p2C))          
                if(CheckForHighCard(p1C) > CheckForHighCard(p2C))
                    return player1;
                else
                    return player2;
            else if(CheckForTwoPairs(p1C) && !(CheckForTwoPairs(p2C)))          
                return player1;
            else if(!(CheckForTwoPairs(p1C) && (CheckForTwoPairs(p2C))))
                return player2;
            else if(CheckForOnePair(p1C) && CheckForOnePair(p2C))
                if(CheckForHighCard(p1C) > CheckForHighCard(p2C))
                    return player1;
                else
                    return player2;
            else if(CheckForOnePair(p1C) && !(CheckForOnePair(p2C)))
                return player1;
            else if(!(CheckForOnePair(p1C) && (CheckForOnePair(p2C))))
                return player2;
            if(CheckForHighCard(p1C) > CheckForHighCard(p2C))
                return player1;
            else 
                return player2;
            
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

        public bool Contains(List<Card> playerCards, Value value)
        {
            return playerCards.Where(c => c.Value == value).Any();
        }

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

        public bool CheckForStraight(List<Card> cards)
        {
            if(Contains(cards, Value.Ace) && 
                Contains(cards, Value.King) &&
                Contains(cards , Value.Queen) && 
                Contains(cards, Value.Jack) &&
                Contains(cards, Value.Ten))
                {
                    return true;
                }

                var ordered = cards.OrderBy(h => h.Value).ToList();
                var straightStart = (int)ordered.First().Value;

                for(int i = 1; i < ordered.Count; i++)
                {
                    if((int) ordered[i].Value != straightStart + i)
                        return false;
                }
                return true;
        }
        public bool CheckForFlush(List<Card> cards)
        {
            return cards.GroupBy(h => h.Suit).Count()==1;
        }

        public bool CheckForFullHouse(List<Card> cards)
        {
            return CheckForOnePair(cards) && CheckForThreeOfAKind(cards);
        }

        public bool CheckForFourOfAKind(List<Card> cards)
        {
            return cards.GroupBy(v => v.Value).Where(z => z.Count() == 4).Any();
        }

        public bool CheckForStraightFlush(List<Card> cards)
        {
            return CheckForFlush(cards) && CheckForStraight(cards);
        }

        public bool CheckForRoyalFlush(List<Card> cards)
        {
            return CheckForStraight(cards) && CheckForFlush(cards) && Contains(cards, Value.Ace) && Contains(cards, Value.King);
        }

    }
}