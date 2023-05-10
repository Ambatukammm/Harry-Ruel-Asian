using Microsoft.VisualBasic.FileIO;
using System;
using System.Threading;

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
                Random rand = new Random();
                int shark = rand.Next(10, 20);
                int surfer = rand.Next(10);
                Console.WriteLine($"The surfer is {surfer} meters from the shore");
                Console.WriteLine($"The shark is {shark - surfer} meters from the surfer");
                Thread.Sleep(1000);
                while (surfer > 0 && shark > surfer)
                {
                    shark = rand.Next(shark - 5);
                    surfer = rand.Next(surfer - 1);
                    Console.WriteLine("\n");
                    Console.WriteLine($"The surfer is {surfer} meters from the shore");
                    Console.WriteLine($"The shark is {shark - surfer} meters from the surfer");
                    if (shark <= surfer)
                    {
                        Console.WriteLine("The shark ate the surfer");
                    }
                    else if (surfer <= 0)
                    {
                        Console.WriteLine("The surfer made it to the shore");
                    }
                    Thread.Sleep(1000);
                }
                Console.ReadLine();
                Console.Clear();
            }
            static void three()
            {
                Console.Clear();
                Console.WriteLine("Welcome to the Adventure Game!");
                Console.WriteLine("You wake up in a dark forest. You don't remember how you got here.");

                string choice = "";
                bool gameOver = false;

                while (!gameOver)
                {
                    Console.WriteLine("What do you want to do?");
                    Console.WriteLine("A. Look for a way out of the forest");
                    Console.WriteLine("B. Wait for someone to find you");

                    choice = Console.ReadLine().ToUpper();

                    if (choice == "A")
                    {
                        Console.WriteLine("You wander through the forest for hours, but you can't find a way out.");
                        Console.WriteLine("As night falls, you hear strange noises in the distance.");
                        Console.WriteLine("Do you:");
                        Console.WriteLine("A. Follow the noises");
                        Console.WriteLine("B. Find a place to hide");

                        choice = Console.ReadLine().ToUpper();

                        if (choice == "A")
                        {
                            Console.WriteLine("You follow the noises and eventually come across a group of friendly travelers.");
                            Console.WriteLine("They help you find your way out of the forest.");
                            Console.WriteLine("Congratulations! You have won the game.");
                            gameOver = true;
                        }
                        else if (choice == "B")
                        {
                            Console.WriteLine("You find a small cave to hide in. Unfortunately, it's not very safe.");
                            Console.WriteLine("You are attacked by a pack of wolves during the night and don't survive.");
                            Console.WriteLine("Game over.");
                            gameOver = true;
                        }
                        else
                        {
                            Console.WriteLine("Invalid choice. Please try again.");
                        }
                    }
                    else if (choice == "B")
                    {
                        Console.WriteLine("You wait for several hours, but nobody comes.");
                        Console.WriteLine("As night falls, you realize that you're not alone in the forest.");
                        Console.WriteLine("Do you:");
                        Console.WriteLine("A. Try to find a weapon");
                        Console.WriteLine("B. Climb a tree to hide");

                        choice = Console.ReadLine().ToUpper();

                        if (choice == "A")
                        {
                            Console.WriteLine("You find a sturdy stick and use it to defend yourself against a pack of wolves.");
                            Console.WriteLine("You survive the night and eventually find your way out of the forest.");
                            Console.WriteLine("Congratulations! You have won the game.");
                            gameOver = true;
                        }
                        else if (choice == "B")
                        {
                            Console.WriteLine("You climb a tree and manage to avoid the predators during the night.");
                            Console.WriteLine("In the morning, you find a path that leads you out of the forest.");
                            Console.WriteLine("Congratulations! You have won the game.");
                            gameOver = true;
                        }
                        else
                        {
                            Console.WriteLine("Invalid choice. Please try again.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid choice. Please try again.");
                    }
                }

                Console.ReadLine();
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

