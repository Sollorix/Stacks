using System;
using System.Collections.Generic;

namespace Stacks_Babcock_Olivia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creates new array.
            Card[] myCardsArray = new Card[]
            {
                // List of items and values in array.
                new Card("Ace", "Clubs"),
                new Card("King", "Hearts"),
                new Card("Queen", "Diamonds"),
                new Card("9", "Spades"),
                new Card("2", "Diamonds"),
                new Card("7", "Hearts"),
                new Card("3", "Spades"),
                new Card("Jack", "Clubs"),
                new Card("King", "Spades")
            };

            // Creates stack for array.
            Stack<Card> startingDeck = new Stack<Card>(myCardsArray);

            // Prints to the console.
            Console.WriteLine("Cards in Deck:");
            // Creates a foreach loop for startingDeck.
            foreach (Card card in startingDeck)
            {
                // Prints to the console.
                Console.WriteLine($"The {card.Number} of {card.Suit}!");
            }

            // Prints to the console.
            Console.WriteLine($"Cards in the stack: {startingDeck.Count}");

            // Creates new list for Card.
            List<Card> myHand = new List<Card>();
            // Adds new Card values.
            myHand.Add(new Card("Queen", "Diamonds"));
            myHand.Add(new Card("8", "Hearts"));
            myHand.Add(new Card("5", "Diamonds"));

            // Prints to the console
            Console.WriteLine("Got any 8's?");
            // Creates an if statement and checks to see if there is more than 0 cards.
            if(startingDeck.Count > 0)
            {
                // Adds a card to myHand by popping it.
                myHand.Add(startingDeck.Pop());
            }

            // Prints to the console.
            Console.WriteLine($"Cards in the deck: {startingDeck.Count}");

            // Puts one of your cards in your hand on the stack.
            startingDeck.Push(myHand[0]);
            // Removes the card placed from your hand.
            myHand.RemoveAt(0);

            //Prints to the console.
            Console.WriteLine("Cards in Deck:");
            // Creates a foreach loop through the stack.
            foreach (Card card in startingDeck)
            {
                // Prints to the console.
                Console.WriteLine($"The {card.Number} of {card.Suit}!");
            }
        }
    }
}