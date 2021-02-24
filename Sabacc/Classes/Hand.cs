using System;
using System.Collections.Generic;
using System.Text;

namespace Sabacc.Classes
{
    public class Hand
    {
        // Properties
        //-----------
        public List<int> CurrentCards { get; private set; } = new List<int>();
        public int CurrentTotal { get; set; }
        public Table Table {get;}

        // Constructor
        //------------
        public Hand(Table table)
        {
            Table = table;
        }

        // Methods
        //--------
        public void Draw()
        {
            CurrentCards.Add(Table.Deck.DealOneCard());
        }
        public void Trade(int indexOfCardToBeTraded)
        {
            CurrentCards.Add(Table.Deck.DealOneCard());
            CurrentCards.Remove(indexOfCardToBeTraded);
        }
    }
}
