using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_5_2019AlgorithmLab
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxRandomNum, timesToRun;
            string input;
            bool passed;
            Random random = new Random();

            Console.Write("Would you like everything to be fully automated? ");
            if (YesOrNo())
            {
                Console.WriteLine("Perfect, the system will run 10,000 times for each algorithm.");
                Console.WriteLine("Each time ran the algorithm will guess a number betwee 0 and 1,001.");
                maxRandomNum = 1000;
                timesToRun = 10000;
            }
            else
            {
                do
                {
                    Console.Write("How large would you like the set of numbers to be: ");
                    input = Console.ReadLine();
                    passed = int.TryParse(input, out maxRandomNum);
                    if (!passed && maxRandomNum >= 1)
                        Console.WriteLine("Sorry, not a valid number!");

                } while (!passed && maxRandomNum >= 1);
                do
                {
                    Console.Write("How many times would you like to run each Algorithm: ");
                    input = Console.ReadLine();
                    passed = int.TryParse(input, out timesToRun);
                    if (!passed && maxRandomNum >= 1)
                        Console.WriteLine("Sorry, not a valid number!");

                } while (!passed && maxRandomNum >= 1);
            }
            Console.WriteLine("");

            List<int> eachCounts = new List<int> { };
            Guesser Brute = new BruteForceGuesser(maxRandomNum, timesToRun);
            Brute.RunNTimes(random);
            Brute.PrintStats();

            Guesser Rando = new RandomGuesser(maxRandomNum, timesToRun);
            Rando.RunNTimes(random);
            Rando.PrintStats();

            Guesser HighLow = new HighOrLowerGuesser(maxRandomNum, timesToRun);
            HighLow.RunNTimes(random);
            HighLow.PrintStats();
        }

        private static bool YesOrNo()
        {
            string input;
            while (true)
            {
                Console.Write("(y/n):");
                input = Console.ReadLine().ToLower();
                if (String.Equals("n", input))
                {
                    return false;
                }
                else if (String.Equals("y", input))
                {
                    return true;
                }
                else
                {
                    Console.WriteLine("That is an invalid entry!");
                    continue;
                }
            }
        }
    }
}
