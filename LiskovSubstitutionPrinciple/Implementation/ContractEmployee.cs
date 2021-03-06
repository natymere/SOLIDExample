using LiskovSubstitutionPrinciple.Interface;

namespace LiskovSubstitutionPrinciple.Implementation
{
    public class ContractEmployee : IEmployee
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ContractEmployee(int id, string name)
        {
            Id = id;
            Name = name;
        }
        
        public decimal GetMinimumSalary()
        {
            return 5000; 
        }
        
        public override string ToString()
        {
            return $"ID {Id}, Name: {Name}";
        }
    }
}