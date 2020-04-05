using System;
using System.Collections.Generic;

namespace pokerHands 
{
    public class Player
    {
        
        private string name;
        public string Name { get; set;}
        private int wins;
        public int Wins {get; set;}
       
        public Player(string name)
        {
            this.Name = name;
            this.Wins = 0;
        }

    }

}