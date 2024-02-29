/*
 * Created By: Samuel McCorkel
 * Created: 11/08/2023
 * Project Black Jack Game
 *  This is the Card class
 */
using System;
using System.ComponentModel.DataAnnotations;
using Project_Blackjack;
namespace Project_Blackjack
{
    /// <summary>
    /// Represents the suits in a standard deck of playing cards.
    /// </summary>
    public enum Suit
    {
        Clubs,
        Diamonds,
        Hearts,
        Spades
    }
    /// <summary>
    /// Represents the faces (ranks) in a standard deck of playing cards.
    /// </summary>
    public enum Face
    {
        Ace,
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King
    }
    /// <summary>
    /// Represents a playing card with a specific suit and face.
    /// </summary>
    public class Card
    {
        /// <summary>
        /// Gets or sets the suit of the card.
        /// </summary>
        public Suit Suit { get; set; }
        /// <summary>
        /// Gets or sets the face (rank) of the card.
        /// </summary>
        public Face Face { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Card"/> class with the specified suit and face.
        /// </summary>
        /// <param name="suit">The suit of the card.</param>
        /// <param name="face">The face (rank) of the card.</param>
        public Card(Suit suit, Face face)
        {
            Suit = suit;
            Face = face;
           
        }
        /// <summary>
        /// Returns a string representation of the card.
        /// </summary>
        /// <returns>A string in the format "{Face} of {Suit}".</returns>
        public override string ToString()
        {
            return $"{Face} of {Suit}";
        }
    }
}
