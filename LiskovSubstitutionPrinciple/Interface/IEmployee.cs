namespace LiskovSubstitutionPrinciple.Interface
{
    interface IEmployee
    {
        int Id { get; set; } 
        string Name { get; set; }
        decimal GetMinimumSalary(); 
    }
}