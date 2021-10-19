using System;

namespace times_tables
{
    class Program
    {

        static void Multiplier(int timesTable)
        {
            Console.WriteLine($"1 x {timesTable} = {timesTable * 1}");
            Console.WriteLine($"2 x {timesTable} = {timesTable * 2}");
            Console.WriteLine($"3 x {timesTable} = {timesTable * 3}");
            Console.WriteLine($"4 x {timesTable} = {timesTable * 4}");
            Console.WriteLine($"5 x {timesTable} = {timesTable * 5}");
            Console.WriteLine($"6 x {timesTable} = {timesTable * 6}");
            Console.WriteLine($"7 x {timesTable} = {timesTable * 7}");
            Console.WriteLine($"8 x {timesTable} = {timesTable * 8}");
            Console.WriteLine($"9 x {timesTable} = {timesTable * 9}");
            Console.WriteLine($"10 x {timesTable} = {timesTable * 10}");
            Console.WriteLine($"11 x {timesTable} = {timesTable * 11}");
            Console.WriteLine($"12 x {timesTable} = {timesTable * 12}");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Input your number to get the times table!");
            string input = Console.ReadLine();
            int inputNumber = Convert.ToInt32(input);
            Multiplier(inputNumber);

        }
    }
}
