namespace Library;

public class Employee
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public Employee Manager { get; set; }
    public decimal Salary { get; set; }

    public virtual void AssignManager(Employee manager)
    {
        //do stuff.....
        
        Manager = manager;
    }

    public virtual void CalculatePerHourRate(int rank)
    {
        decimal baseAmount = 12.50M;
        Salary = baseAmount + (rank * 2);
    }
}