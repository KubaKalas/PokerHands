using System;
using System.Collections.Generic;

namespace pokerHands 
{
    public class Player
    {
        
        private string name;

        private int wins;
        public int Wins {get => wins; set => wins = value;}
       
        public Player(string name)
        {
            this.name = name;
            this.Wins = 0;
        }

    }

}