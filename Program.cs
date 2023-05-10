using System;

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

            while (!isCorrect && attempts < 10)
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

                        Console.WriteLine($"Congratulations! You guessed {secretNumber} in {attempts} attempts.\nGood job you monkey");

                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer.");
                }
            }

            Console.WriteLine("Press My Ass to exit.");
            Console.WriteLine("    ______");
            Console.WriteLine("  (((((    \\");
            Console.WriteLine("   ); \\\\|)|");
            Console.WriteLine("  <   ||||||/");
            Console.WriteLine("   >  ///////");
            Console.WriteLine("   `--| abac");
            Console.WriteLine("   ___/     \\___⠄");
            Console.WriteLine("(    ~        ~   )");
            Console.WriteLine("\\  `              /");
            Console.WriteLine("| \\             / |");
            Console.WriteLine("| -\\           /  /");
            Console.WriteLine("(__ |     |   |- ,");
            Console.WriteLine("    |     |   |");
            Console.WriteLine("    /          \\");
            Console.WriteLine("   /     `,     \\");
            Console.WriteLine("  |       )      )");
            Console.WriteLine("  |      _/_   _ /");
            Console.WriteLine("   \\      |      |");
            Console.WriteLine("    |     |      ,");
            Console.ReadKey();

        }
    }
}
