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

            Console.WriteLine($"\nCalculated Age: {DateTime.Now.Year - birthYear}");
            int age = (DateTime.Now.Year - birthYear);

            if (age >= 0 && age <= 17)
            { Console.WriteLine("Readiness Category: Child\n"); }
            else if (age >= 18 && age <= 64)
            { Console.WriteLine("Readiness Category: Adult\n"); }
            else if (age >= 65)
            { Console.WriteLine("Readiness Category: Elder\n"); }

            Console.Write("Do you have a valid ID? (yes/no): ");
            string validID = Console.ReadLine();
            bool idTrue = (validID == "yes");

            Console.Write("Have you completed orientation? (yes/no): ");
            string completeOri = Console.ReadLine();
            bool passedOri = (completeOri == "yes");

            if (age >= 18)
            {
                if (idTrue && passedOri)
                { Console.WriteLine("Readiness Status: Ready!"); }
                else if (idTrue || passedOri)
                { Console.WriteLine("Readiness Status: Conditionally Ready."); }
                else
                { Console.WriteLine("Readiness Status: Not Ready..."); }

                Console.WriteLine("\nSelect a guidance option (1/2/3): ");
                Console.WriteLine("1 - Academic Planning");
                Console.WriteLine("2 - Personal Planning");
                Console.WriteLine("3 - Career Planning");
                Console.Write("Enter choice: ");
                int guidanceOption = int.Parse(Console.ReadLine());

                switch (guidanceOption)
                {       case 1: Console.WriteLine("\nGuidance: \nTalk to an academic counselor to plan your next term."); break;
                        case 2: Console.WriteLine("\nGuidance: \nCreate a personal schedule with a teacher to balance school and life."); break;
                        case 3: Console.WriteLine("\nGuidance: \nFind a career project manager to find career options and internships realted to your major."); break;
                        default: Console.WriteLine("\nGuidance: \nERROR: Invalid guidance option..."); break;
                }

            }
        }
    }
}
