using System;

namespace times_tables
{
    class Program
    {

        static void Multiplier(int timesTable)
        {
            for (int i = 1; i < 0 + 13; i++)
            {
            Console.WriteLine($"{i} x {timesTable} = {timesTable * i}");
            }
        }
        static void Main(string[] args)
        {
            bool doAgain = true;
            while (doAgain == true)
            {            
                Console.WriteLine("Which times table do you want to see? Type in a number, or type E to end program.");
                string input = Console.ReadLine();
                if(int.TryParse(input, out int inputNumber))
                {
                    Multiplier(inputNumber);
                }

                else if (input == "E" || input == "e")
                {
                    doAgain = false;
                }

                else
                {
                    Console.WriteLine("We didn't quite get that!");
                }
            }

        }
    }
}
