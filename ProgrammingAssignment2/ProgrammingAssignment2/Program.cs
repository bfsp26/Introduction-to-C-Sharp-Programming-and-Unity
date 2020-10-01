using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleCards;

namespace ProgrammingAssignment2
{
    // IMPORTANT: Only add code in the section
    // indicated below. The code I've provided
    // makes your solution work with the 
    // automated grader on Coursera

    /// <summary>
    /// Programming Assignment 2
    /// </summary>
    class Program
    {
        /// <summary>
        /// Implements Nothing Like Blackjack functionality
        /// </summary>
        /// <param name="args">command-line args</param>
        static void Main(string[] args)
        {
            // loop while there's more input
            string input = Console.ReadLine();
            while (input[0] != 'q')
            {

                // Add your code between this comment
                // and the comment below. You can of
                // course add more space between the
                // comments as needed

                // declare a deck variables and create a deck object
                // DON'T SHUFFLE THE DECK

                Deck deck = new Deck();
                deck.TakeTopCard();
                Console.WriteLine(deck.TakeTopCard());

                // deal 2 cards each to 4 players (deal properly, dealing
                // the first card to each player before dealing the
                // second card to each player)

                // deal 1 more card to players 2 and 3

                // flip all the cards over

                // print the cards for player 1

                // print the cards for player 2

                // print the cards for player 3

                // print the cards for player 4

                // Don't add or modify any code below
                // this comment
                input = Console.ReadLine();
            }
        }
    }
}
