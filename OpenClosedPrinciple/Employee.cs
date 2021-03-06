namespace OpenClosedPrinciple
{
    // abstract employee
    public abstract class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string EmployeeType { get; set; }

        public Employee()
        {
        }

        public Employee(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public abstract decimal CalculateBonus(decimal salary);

        public override string ToString()
        {
            return $"ID {Id}, Name: {Name}";
        }
    }
    
    // interface for permanant employee
    interface IPermamnentEmployee
    {
        public decimal CalculateBonus(decimal salary);
    }
    
    // interface for temporary employee
    interface ITemporaryEmployee
    {
        public decimal CalculateBonus(decimal salary);
    }

    public class EmployeeA : IPermamnentEmployee
    {
        public decimal CalculateBonus(decimal salary)
        {
            return salary * .1M;
        }
    }
    
    public class EmployeeB : ITemporaryEmployee
    {
        public decimal CalculateBonus(decimal salary)
        {
            return salary * .05M;
        }
    }

    public class PermanantEmployee : Employee
    {
        public string PermanantPass;
        public PermanantEmployee(int id, string name) : base(id, name)
        {
        }
        
        public override decimal CalculateBonus(decimal salary)
        {
            return salary * .1M;
        }
    }
    
    public class TemporaryEmployee : Employee
    {
        public TemporaryEmployee(int id, string name) : base(id, name)
        {
        }
        
        public override decimal CalculateBonus(decimal salary)
        {
            return salary * .05M;
        }
    }
}