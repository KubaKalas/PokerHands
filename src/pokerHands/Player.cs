using System;
using System.Collections.Generic;

namespace pokerHands 
{
    public class Player
    {
        
        public string name { get; }
        public int wins {get; set;}
       
        public Player(string name)
        {
            this.name = name;
            this.wins = 0;
        }

    }

}