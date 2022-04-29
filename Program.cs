using System;
using System.Collections.Generic;

namespace all_cards_on_deck
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("all-cards-on-deck");
        }
        // Objectives

        // Demonstrate usage of List or arrays to model resources.
        // Understand and implement algorithms.
        // Understand loops.
        // Requirements

        // Your deck should contain 52 unique cards.
        // All cards should be represented as a string such as "Ace of Hearts"
        // There are four suits: "Clubs", "Diamonds", "Hearts", and "Spades".
        // There are 13 ranks: "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", and "King".
        // You will model these in code, in any way you see fit. It may require you to experiment and try several techniques. 
        //There are many valid solutions.

        // NOTE: The more you plan this out (focus on the algorithm) the better you will do.
        //<-------------------//-------------------->

        // Algorithm to shuffle deck
        // numberOfCards = length of our deck

        // for rightIndex from numberOfCards - 1 down to 1 do:
        // leftIndex = random integer that is greater than or equal to 0 and LESS than rightIndex. 
        // See the section "How do we get a random integer")

        // Now swap the values at rightIndex and leftIndex by doing this:
        // leftCard = the value from deck[leftIndex]
        // rightCard = the value from deck[rightIndex]
        // deck[rightIndex] = leftCard
        // deck[leftIndex] = rightCard

        //hint: understand the algorithm before you try to implement it.


        // How do we get a random integer like the algorithm asks us to?

        // As we have seen, computers do exactly what we tell them to do. Thus, computers are bad at generating truly random numbers. Randomness is a deep and complex topic, but it's worth pointing out that most random numbers we use in computing are what we call "pseudorandom". That is, they generate numbers that appear to be random such that guessing the next random number the computer's fixed algorithm is going to generate is very difficult. This makes it good enough for most purposes. For this assignment, you will read about, then implement, a popular algorithm that shuffles a list using C#'s built-in Random.Next() function as a pseudorandom number generator.
        // Hint: Here is an example of code that gives us a random number greater, or equal to 0 and less than 956.

        // var randomNumberGenerator = new Random();
        // var randomNumber = randomNumberGenerator.Next(956);

        // When using this code you could replace the specific value 956 with rightIndex like in the algorithm.


        /* --------------START ALGORITHM


        #Card_Deck
        52 cards
        4 suits - H C S D
        breakdown: A,2,3,4,5,6,7,8,9,10,J,Q,K
          */

        var counter = 0;
      
        var suits = new list<string>();
        suits["Hearts"];
        
        {
          Console.WriteLine($"{suits} is the highest value suit in a deck");
        }
}
}