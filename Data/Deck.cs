/*
 * Created By: Samuel McCorkel
 * Created: 11/08/2023
 * this is the Deck class where the deck is created and suffled
 * Project  BlackJack
 */
using System;
using System.ComponentModel.DataAnnotations;
using Project_Blackjack;
namespace Project_Blackjack
{
    /// <summary>
    /// Represents a standard deck of playing cards used in a blackjack game.
    /// </summary>
    public class Deck
    {
        /// <summary>
        /// Gets or sets the list of cards in the deck.
        /// </summary>
        private List<Card> Cards { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Deck"/> class.
        /// </summary>
        public Deck()
        {
            Cards = new List<Card>();
            // Populate the deck with all possible combinations of suits and faces.
            foreach (Suit suit in Enum.GetValues(typeof(Suit)))
            {
                foreach (Face face in Enum.GetValues(typeof(Face)))
                {
                    Cards.Add(new Card(suit, face));
                }
            }
            // Shuffle the deck upon initialization.
            Shuffle();
        }
        /// <summary>
        /// Shuffles the cards in the deck using a random order.
        /// </summary>
        public void Shuffle()
        {
            Cards = Cards.OrderBy(x => Guid.NewGuid()).ToList();
        }
        /// <summary>
        /// Draws a card from the deck.
        /// </summary>
        /// <returns>The drawn card.</returns>
        public Card DrawCard()
        {
            // Retrieve the top card from the deck and remove it.
            Card card = Cards[0];
            Cards.RemoveAt(0);
            return card;
        }
    }
}


