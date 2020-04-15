
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_5_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            int userChoice;
            do
            {
                userChoice = GetMenu();
                if (userChoice == 1)
                {
                    for (int i = 1; i <= 100; i++)
                    {
                        Console.WriteLine(i);
                    }
                }

                else if (userChoice == 2)
                {
                    for (int i = 100; i >= 1; i--)
                    {
                        Console.WriteLine(i);
                    }
                }

                else if (userChoice == 3)
                {
                    CountTo100By2s();
                }

                else if (userChoice == 4)
                {
                    break;
                }

                else if (userChoice > 4 || userChoice < 1)
                {
                    Console.WriteLine("Error");
                }
            } while (true);
        }

        static void CountTo100By2s()
        {
            for (int i = 2; i <= 100; i += 2)
            {
                Console.WriteLine(i);
            }
        }

        static int GetMenu()
        {
            Console.WriteLine("Welcome to the Counting Menu! Please pick and option between 1 and 4!");
            Console.WriteLine("1: Count to 100.");
            Console.WriteLine("2: Count down from 100.");
            Console.WriteLine("3: Count to 100 by 2's.");
            Console.WriteLine("4. Exit.");
            Console.Write("Choice: ");
            int userChoice;
            userChoice = int.Parse(Console.ReadLine());
            return userChoice;
        }
    }
}
