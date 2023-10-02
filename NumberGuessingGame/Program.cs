using System;

namespace NumberGuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int guessTries = 1;

            // The program will start with the following message:
            Console.WriteLine("Welcome to the Guessing Game! Can you guess the number I am thinking?");
            Console.WriteLine("Remember, you have 5 tries.");

            
            
            // This loop will allow user to guess the number in 5 tries
            for (guessTries = 1; guessTries <= 5; guessTries++)
            {
                // Asking user to guess the number
                Console.Write("Try: "+guessTries);
                Console.WriteLine();
                Console.Write("Guess the number: ");
                //Console.WriteLine();

                int userInput = int.Parse(Console.ReadLine());

                bool isCorrect = CheckGuess(userInput);

                // If the guess is right, the game will exit loop here
                if (isCorrect)
                {
                    Console.WriteLine("Yes! You guessed it right!");
                    Console.WriteLine("Press ENTER to exit...");
                    Console.ReadLine();
                    break;
                }

                else if (guessTries == 5) // If the user has guessed five times and did not get the number right, tell them they failed
                {
                    Console.WriteLine("Sorry, you have no more tries left. you couldn't guess the number.");
                    Console.WriteLine("Press ENTER to exit...");
                    Console.ReadLine();

                }

            }


            // Creating a separate function/method to check if the number is guessed right or not
            static bool CheckGuess(int guessedNumber)
            {
                // Here generating a random number between 1 and 20
                Random random = new Random();
                int randomNumber = random.Next(1, 20);


                // Using 'if-else' to check the status of the guess, whether it is right or wrong, low or high.
                if (guessedNumber == randomNumber) // If the guessedNumber and desired number is same.

                {
                    return true; //As the function/method is bool type, it will return either 'true' or 'false'
                }
                else if (guessedNumber < randomNumber) // If the guessedNumber is lower than the randomNumber

                {
                    Console.WriteLine("Oj, you've guessed it too low! Guess again...");
                    return false;
                }
                else // The user guessed higher than the desired randomNumber
                {
                    Console.WriteLine("Oj Oj, you've guessed it too high! Guess again...");
                    return false;
                }
            }
        }
    }
}