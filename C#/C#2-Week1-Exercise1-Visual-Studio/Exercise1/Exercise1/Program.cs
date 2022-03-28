using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleCards;

namespace Exercise1
{
    /// <summary>
    /// Exercise 1 solution
    /// </summary>
    class Program
    {
        /// <summary>
        /// Practices using arrays
        /// </summary>
        /// <param name="args">command-line arguments</param>
        static void Main(string[] args)
        {
            // Problem 1: Create objects: deck & 5 cards
            Deck deck = new Deck();
            Card[] cards = new Card[4];
            
            // Tell the deck to shuffle itself
            deck.Shuffle();
            
            // Problem 2: Add card to the array(Take a card from the top of the deck and add it to element 0 in the array), flip it over, print it
            cards[0] = deck.TakeTopCard();
            cards[0].FlipOver();
            cards[0].Print();
            
            // Problem 3: Add another card to the array, flip it over, print both cards
            // Take a card from the top of the deck, add it to element 1 in the array.
            // Flip the card at element 1 of the array over.
            // Tell the cards at elements 0 & 1 of the array to print themselves
            cards[1] = deck.TakeTopCard();
            cards[1].FlipOver();
            cards[1].Print();
            cards[0].Print();
            
            Console.WriteLine();
        }
        
    }
}
