using System;
using System.Collections.Generic;
using System.Text;

namespace Sabacc.Classes
{
    public class Card
    {
        // Properties
        //-----------
        // Static Properties
        // These are simply lists of the suits and of the royals.
        public static List<string> SuitNames = new List<string>()
        {
            "Coins",
            "Flasks",
            "Sabers",
            "Staves"
        };
        public static int HighestRank = 16;
        public static Dictionary<string, int> Royals = new Dictionary<string, int>()
        {
            {"The Star", -17 },
            {"The Evil One", -15 },
            {"Moderation", -14 },
            {"Demise", -13 },
            {"Balance", -11 },
            {"Endurance", -8 },
            {"Queen of Air and Darkness", -2 },
            {"Idiot", 0 }
        };

        // Public Properties and Backing Properties.
        public bool isFaceUp { get; private set; } = false;
        private int _FaceValue { get; set; }
        public int FaceValue
        {
            get
            {
                return isFaceUp ? _FaceValue : 99;
            }
            private set
            {
                _FaceValue = value;
            }
        }
        private string _Suit { get; set; }
        public string Suit
        {
            get
            {
                return isFaceUp ? _Suit : "99";
            }
            private set
            {
                _Suit = value;
            }
        }
        public string Rank
        {
            get
            {
                string rank = "1";

                if (_FaceValue == 15)
                {
                    rank = "Ace";
                }
                else if (_FaceValue == 14)
                {
                    rank = "Master";
                }
                else if (_FaceValue == 13)
                {
                    rank = "Mistress";
                }
                else if (_FaceValue == 12)
                {
                    rank = "Commander";
                }
                else if (_FaceValue == -17)
                {
                    rank = "The Star";
                }
                else if (_FaceValue == -15)
                {
                    rank = "The Evil One";
                }
                else if (_FaceValue == -14)
                {
                    rank = "Moderation";
                }
                else if (_FaceValue == -13)
                {
                    rank = "Demise";
                }
                else if (_FaceValue == -11)
                {
                    rank = "Balance";
                }
                else if (_FaceValue == -8)
                {
                    rank = "Endurance";
                }
                else if (_FaceValue == -2)
                {
                    rank = "Queen of Air and Darkness";
                }
                else if (_FaceValue == 0)
                {
                    rank = "Idiot";
                }
                else
                {
                    rank = _FaceValue.ToString();
                }

                return isFaceUp ? rank : "99";
            }
        }

        // Constructors
        //-------------
        public Card(int faceValue, string suit)
        {
            _FaceValue = faceValue;
            _Suit = suit;
        }
        public Card(int faceValue, string suit, bool faceUp)
        {
            _FaceValue = faceValue;
            _Suit = suit;
            isFaceUp = faceUp;
        }

        // Methods
        //--------
        public void Flip()
        {
            isFaceUp = !isFaceUp;
        }
        public void Flip(bool isFaceUp)
        {
            this.isFaceUp = isFaceUp;
        }
    }
}
