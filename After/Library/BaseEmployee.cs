namespace Library;

public abstract class BaseEmployee:IEmployee
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public decimal Salary { get; set; }
    

    public virtual void CalculatePerHourRate(int rank)
    {
        const decimal baseAmount = 12.50M;
        Salary = baseAmount + (rank * 2);
    }
}