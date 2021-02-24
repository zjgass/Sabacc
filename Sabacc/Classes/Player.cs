using System;
using System.Collections.Generic;
using System.Text;

namespace Sabacc.Classes
{
    public class Player
    {
        // Properties
        //-----------
        private Hand Hand { get; }
        private Table Table { get; } = new Table();
        private int Credits { get; set; }
        private int Score { get; set; }
        
        // Constructor
        //------------
        public Player(Table table)
        {
            Table = table;
            Hand = new Hand(Table);
        }

        // Methods
        //--------
        public int Bid(int creditsToBid)
        {
            int bid = 0;

            if (creditsToBid <= Credits)
            {
                Credits -= creditsToBid;
                bid = creditsToBid;
            }
            else
            {
                throw new Exception("You're outta credits bub.");
            }

            return bid;
        }
    }
}
