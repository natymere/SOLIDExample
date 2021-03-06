using System;

namespace OpenClosedPrinciple
{
    public static class Program
    {
        static void Main(string[] args)
        {
            PermanantEmployee empJohn = new PermanantEmployee(1, "John");
            TemporaryEmployee empJason = new TemporaryEmployee(2, "empJason");
            
            Console.WriteLine($"Employee {empJohn.ToString()} Bonus {empJohn.CalculateBonus(10000)}");
            Console.WriteLine($"Employee {empJason.ToString()} Bonus {empJason.CalculateBonus(15000)}");
        }
    }
} 