using System;

namespace Practise_Git
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int option;

            do
            {
                Console.WriteLine("Please select an option to play a game");
                Console.WriteLine("1. Guessing Number Game");
                Console.WriteLine("2. Task 2");
                Console.WriteLine("3. Task 3");
                Console.WriteLine("4. Task 4");
                Console.WriteLine("0. Exit");

                option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        one();
                        break;
                    case 2:
                        two();
                        break;
                    case 3:
                        three();
                        break;
                    case 4:
                        four();
                        break;
                    case 0:
                        Console.WriteLine("Exit");
                        break;
                    default:
                        bye();
                        break;
                }
            } while (option != 0);


            static void one()
            {
                Console.Clear();

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

                Console.ReadLine();
                Console.Clear();
            }
            static void two()
            {
                Console.Clear();
                Console.WriteLine("This is Task 2 \npress enter");
                Console.ReadLine();
                Console.Clear();
            }
            static void three()
            {
                Console.Clear();
                Console.WriteLine("This is Task 3 \npress enter");
                Console.ReadLine();
                Console.Clear();
            }
            static void four()
            {
                Console.Clear();
                Console.WriteLine("This is Task 4 \npress enter");
                Console.ReadLine();
                Console.Clear();
            }
            static void bye()
            {
                Console.Clear();
                Console.WriteLine("Invalid");
                Console.ReadLine();
                Console.Clear();
            }
        }



    

        }
    }

