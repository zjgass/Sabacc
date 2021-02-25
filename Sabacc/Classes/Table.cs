using System;
using System.Collections.Generic;
using System.Text;

namespace Sabacc.Classes
{
    public class Table
    {
        // Properties
        //-----------
        public Deck Deck { get; } = new Deck();
        public int Pot { get; private set; } = 0;
        public int SabaccPot { get; private set; } = 0;
        public List<Player> players { get; } = new List<Player>();
        public int TurnCount { get; private set; } = 0;

        // Constructor
        //------------
        public Table(int numberOfPlayers, int initialCredits)
        {
            Pot = 0;
            SabaccPot = 0;
            Deck.Shuffle();

            for (int i = 0; i < numberOfPlayers; i++)
            {
                Player player = new Player(this.Table);
                players.Add();
            }
        }
    }
}
