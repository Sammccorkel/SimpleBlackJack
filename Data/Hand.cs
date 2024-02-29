/*
 * Created By: Samuel McCorkel
 * Created: 11/08/2023
 * This is used for each users hand.
 * Project BlackJack
 */
using System;
using System.ComponentModel.DataAnnotations;
using Project_Blackjack;
namespace Project_Blackjack
{
    /// <summary>
    /// Represents a hand of cards in a blackjack game.
    /// </summary>
    public class Hand
    {
        /// <summary>
        /// Gets or sets the list of cards in the hand.
        /// </summary>
        public List<Card> Cards { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Hand"/> class.
        /// </summary>
        public Hand()
        {
            Cards = new List<Card>();
        }
        /// <summary>
        /// Adds a card to the hand.
        /// </summary>
        /// <param name="card">The card to be added to the hand.</param>
        public void AddCard(Card card)
        {
            Cards.Add(card);
        }
        /// <summary>
        /// Calculates and returns the total value of the hand in a blackjack game.
        /// </summary>
        /// <returns>The total value of the hand.</returns>
        public int GetHandValue()
        {
            int total = 0;
            int aces = 0;

            foreach (Card card in Cards)
            {
                if (card.Face == Face.Ace)
                {
                    aces++;
                }
                else if (card.Face <= Face.Ten)
                {
                    total += (int)card.Face;
                }
                else
                {
                    total += 10;
                }
            }

            for (int i = 0; i < aces; i++)
            {
                if (total + 11 <= 21)
                {
                    total += 11;
                }
                else
                {
                    total += 1;
                }
            }

            return total;
        }
    }

}


