using System;
using System.Collections.Generic;

namespace pokerHands 
{
    public class Player
    {
        
        public string name { get; }
        public int wins 
        {   get => wins;
            set => wins++; 
        }
       
        public Player(string name)
        {
            this.name = name;
            this.wins = 0;
        }

    }

}