using System;
using System.Collections.Generic;

namespace allCardsOnDeck
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Requirements
            // Your deck should contain 52 unique deck.
            // All deck should be represented as a string such as "Ace of Hearts"
            // There are four suits: "Clubs", "Diamonds", "Hearts", and "Spades".  
            // There are 13 faces: "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", and "King".
            
            #Card_Deck
            52 deck
            4 suits - H C S D
            breakdown: A,2,3,4,5,6,7,8,9,10,J,Q,K
            
           #deck = suit at position 0 
           #cards 
           each card in cards
           when cards <13 
           go to position ++ in suits until suits <4
           repeat from #cards
            */

            var suits = new List<string>() { "Hearts", "Spades", "Diamonds", "Clubs" };
            var faces = new List<string>() { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King" };
            var deck = new List<string>();

            // - Make a loop that goes through all the suits
            foreach (var suit in suits)
            {
                //   Make a loop that goes through all the 'faces'
                //   add newly formed string to the end of the deck list - For Suit = Clubs

                foreach (var face in faces)
                {
                    //   Make a loop that goes through all the faces
                    //   for each faces, make a new string of the form $"{face} of spades"
                    //   add newly formed string to the end of the deck list
                    var card = ($"{face} of {suit}");
                    // Console.WriteLine(card);
                    deck.Add(card);
                }

            }

            // // NOTE: The more you plan this out (focus on the algorithm) the better you will do.
            // //<-------------------//-------------------->

            //     // Algorithm to shuffle deck
            //     // numberOfCards = length of our deck
            var numberOfCards = deck.Count; /*<---works*/

            //     // // for rightIndex from numberOfCards - 1 down to 1 do:
            for (var rightIndex = numberOfCards - 1; rightIndex >= 1; rightIndex--)
            {
                //  // leftIndex = random integer that is greater than or equal to 0 and LESS than rightIndex. 
                // var randomNumberGenerator = new Random();
                // var randomNumber = randomNumberGenerator.Next(956);
                var randomNumberGenerator = new Random();
                var leftIndex = randomNumberGenerator.Next(rightIndex);
                // // See the section "How do we get a random integer")

                // // Now swap the values at rightIndex and leftIndex by doing this:
                // leftCard = the value from deck[leftIndex]
                var leftCard = deck[leftIndex];
                // rightCard = the value from deck[rightIndex]
                var rightCard = deck[rightIndex];
                deck[rightIndex] = leftCard;
                deck[leftIndex] = rightCard;
            }

            foreach (var card in deck)
            {
                Console.WriteLine(card);
            }
            //     //hint: understand the algorithm before you try to implement it.


            //     // How do we get a random integer like the algorithm asks us to?

            //     // As we have seen, computers do exactly what we tell them to do. Thus, computers are bad at generating truly random numbers. Randomness is a deep and complex topic, but it's worth pointing out that most random numbers we use in computing are what we call "pseudorandom". That is, they generate numbers that appear to be random such that guessing the next random number the computer's fixed algorithm is going to generate is very difficult. This makes it good enough for most purposes. For this assignment, you will read about, then implement, a popular algorithm that shuffles a list using C#'s built-in Random.Next() function as a pseudorandom number generator.
            //     // Hint: Here is an example of code that gives us a random number greater, or equal to 0 and less than 956.



            //     // When using this code you could replace the specific value 956 with rightIndex like in the algorithm.


        }
    }
}
