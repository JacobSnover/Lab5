using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Welcome to the Grand Circus Casino. Roll the dice? (y/n) ");
            string response = Console.ReadLine().ToLower();

            while (true)
            {

                if (response == "y" || response == "yes")
                {
                    Console.Write("If your dice had 10 sides or less, what would you prefer? ");
                    string input = Console.ReadLine();
                    int roll = DiceRoller(input);
                    Console.WriteLine($"{roll}");
                    int roll2 = DiceRoller(input);
                    Console.WriteLine($"{roll2}");
                    while (true)
                    {

                        Console.Write("Roll again (y/n)? ");
                        string test = Console.ReadLine().ToLower();

                        if (test == "y" || test == "yes")
                        {
                            break;
                        }
                        else if (test == "n" || test == "no")
                        {
                            Console.WriteLine("Bye");
                            Console.ReadLine();
                            Environment.Exit(1);
                        }

                    }
                }
                else if (response == "n" || response == "no")
                {
                    Console.WriteLine("Bye");
                    Console.ReadLine();
                    Environment.Exit(1);
                }

            }



        }
        public static int DiceRoller(string input)
        {
            while (true)
            {

                if (!int.TryParse(input, out int sides) || sides <= 0 || sides > 10)
                {
                    Console.WriteLine($"Sorry but {input}, is not a proper response");
                    Console.Write("If your dice had 10 sides or less, what would you prefer? ");
                    input = Console.ReadLine();
                }
                else
                {
                    Random r1 = new Random();
                    int roll = r1.Next(1, sides);
                    return roll;

                }
            }

        }

    }
}
