using LiskovSubstitutionPrinciple.Abstract;

namespace LiskovSubstitutionPrinciple.Implementation
{
    public class TemporaryEmployee : Employee
    {
        public TemporaryEmployee(int id, string name) : base(id, name)
        {
        } 

        public override decimal GetMinimumSalary()
        {
            return 5000;
        }

        public override decimal CalculateBonus(decimal salary)
        {
            return salary * 0.5M;
        }
    }
}

