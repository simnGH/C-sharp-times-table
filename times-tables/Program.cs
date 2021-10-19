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
            Console.WriteLine("Which times table do you want to see?");
            string input = Console.ReadLine();
            int inputNumber = Convert.ToInt32(input);
            Multiplier(inputNumber);

        }
    }
}
