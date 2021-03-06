using LiskovSubstitutionPrinciple.Interface;

namespace LiskovSubstitutionPrinciple.Abstract
{
    public abstract class Employee : IEmployee, IEmployeeBonus
    {
        public int Id { get; set; }
        public string Name { get; set; }

 
        public Employee(int id, string name)
        {
            Id = id;
            Name = name;
        }
        
        public abstract decimal GetMinimumSalary();

        public abstract decimal CalculateBonus(decimal salary);

        public override string ToString()
        {
            return $"ID {Id}, Name: {Name}";
        }
    }

}
