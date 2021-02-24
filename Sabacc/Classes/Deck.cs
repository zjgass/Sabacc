using System;
using System.Collections.Generic;
using System.Text;

namespace Sabacc.Classes
{
    public class Deck
    {
        // Properties
        //-----------
        public int NumberOfCardsInDeck { get; private set; }
        private List<Card> AllCards { get; set; } = new List<Card>();
        private List<int> CardsDealtOut = new List<int>();

        // Constructor
        //------------
        public Deck()
        {
            foreach (string suit in Card.SuitNames)
            {
                for (int i = 1; i < Card.HighestRank; i++)
                {
                    Card card = new Card(i, suit);
                    AllCards.Add(card);
                    NumberOfCardsInDeck++;
                }
            }
            foreach (KeyValuePair<string, int> royal in Card.Royals)
            {
                Card card = new Card(royal.Value, royal.Key);
                AllCards.Add(card);
                NumberOfCardsInDeck++;
            }
        }

        // Methods
        //--------
        public void Shuffle()
        {
            Random r = new Random();

            for (int i = 0; i < 1000000; i++)
            {
                int randomSpot1 = r.Next(AllCards.Count);
                int randomSpot2 = r.Next(AllCards.Count);

                Card tempCard = AllCards[randomSpot2];
                AllCards[randomSpot2] = AllCards[randomSpot1];
                AllCards[randomSpot1] = tempCard;
            }
        }
        public void SabaccShift()
        {
            Random r = new Random();

            for (int i = 0; i < 50; i++)
            {
                int randomSpot1 = r.Next(AllCards.Count);
                int randomSpot2 = r.Next(AllCards.Count);

                if (!AllCards[randomSpot1].isFaceUp && !AllCards[randomSpot2].isFaceUp)
                {
                    Card tempCard = AllCards[randomSpot2];
                    AllCards[randomSpot2] = AllCards[randomSpot1];
                    AllCards[randomSpot1] = tempCard;
                }
            }
        }
        public int DealOneCard()
        {
            int indexOfCard = 0;
            Random r = new Random();

            do          // Find an index to a card that is not already in use
            {
                indexOfCard = r.Next(AllCards.Count);
            } while (!CardsDealtOut.Contains(indexOfCard));
            CardsDealtOut.Add(indexOfCard);

            return indexOfCard;
        }
        public bool ReturnOneCard(int indexOfCard)
        {
            bool cardReturned = false;

            if (CardsDealtOut.Contains(indexOfCard))
            {
                CardsDealtOut.Remove(indexOfCard);
                cardReturned = true;
            }
            else
            {
                throw new Exception("Cheater! That card was not from this deck!");
            }

            return cardReturned;
        }
        public Card WhatCard(int indexOfCard)
        {
            return AllCards[indexOfCard];
        }
    }
}
