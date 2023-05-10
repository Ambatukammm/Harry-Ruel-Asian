﻿using System;

namespace Practise_Git
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int secretNumber = random.Next(1, 101);
            int attempts = 0;
            bool isCorrect = false;

            Console.WriteLine("Welcome to the Number Guessing Game!");

            while (!isCorrect)
            {
                Console.Write("Enter your guess (1-100): ");
                string input = Console.ReadLine();
                int guess;

                if (int.TryParse(input, out guess))
                {
                    attempts++;

                    if (guess < secretNumber)
                    {
                        Console.WriteLine("Too low! Try again.");
                    }
                    else if (guess > secretNumber)
                    {
                        Console.WriteLine("Too high! Try again.");
                    }
                    else
                    {
                        isCorrect = true;

<<<<<<< HEAD
                        Console.WriteLine($"Congratulations! you got the {secretNumber} in {attempts} guesses! get good kid lol.");

                        Console.WriteLine($"Congratulations! Don't know what to write {secretNumber} in {attempts} attempts.");

=======
                        Console.WriteLine($"Congratulations! Dont know what to write {secretNumber} in {attempts} attempts.");
>>>>>>> 252f52a729912f5877705dd556ebf6fc76a89094
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer.");
                }
            }

            Console.WriteLine("Press My Ass to exit.");
            Console.ReadKey();
        }
    }
}
