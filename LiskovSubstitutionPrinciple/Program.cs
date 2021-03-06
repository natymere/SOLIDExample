 using System;
 using System.Collections.Generic;
 using LiskovSubstitutionPrinciple.Abstract;
 using LiskovSubstitutionPrinciple.Implementation;
 using LiskovSubstitutionPrinciple.Interface;

 namespace LiskovSubstitutionPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Employee empJohn = new PermanentEmployee(1, "John");
            Employee empJason = new TemporaryEmployee(2, "Jason");
            

            List<Employee> employees = new List<Employee>();
            employees.Add(empJohn);
            employees.Add(empJason);

            foreach (var employee in employees)  
            {
                Console.WriteLine($"Employee {employee.ToString()} Bonus {employee.CalculateBonus(employee.GetMinimumSalary())}");
            }

            // Liskov Substitution states that no new exception can be thrown by subtypes
            // Clients should not know which specific subtype they are calling
            // New derived classes just extend without replacing the functionality of old classes
            List<IEmployee> employeesOnly = new List<IEmployee>();
            
            employeesOnly.Add(new PermanentEmployee(1, "John"));
            employeesOnly.Add(new TemporaryEmployee(2, "Jason"));
            employeesOnly.Add(new ContractEmployee(3, "Karin"));

            foreach (var employee in employeesOnly)
            {
                Console.WriteLine($"Employee {employee.ToString()} MinSalary: {employee.GetMinimumSalary()}");
            }
        }
    }
}