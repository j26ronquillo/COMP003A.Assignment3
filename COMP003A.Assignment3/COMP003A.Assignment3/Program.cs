using System.Transactions;

namespace COMP003A.Assignment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Academic & Personal Readiness Evaluator ===\n");
            Console.WriteLine($"Current Year: {DateTime.Now.Year}");
            Console.Write("Enter your birth year: ");
            int birthYear = int.Parse(Console.ReadLine());

            Console.WriteLine($"Calculated Age: {DateTime.Now.Year - birthYear}");

            if (birthYear >= 0 && birthYear <= 14)
            { Console.WriteLine("Child"); }
            else if (birthYear >= 15 && birthYear <= 64)
            { Console.WriteLine("Adult"); }
            else if (birthYear >= 65)
            { Console.WriteLine("Elder"); }
        }
    }
}
