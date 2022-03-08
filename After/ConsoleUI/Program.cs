using Library;

internal class Program
{
    private static void Main(string[] args)
    {
        Manager accountingVp = new Manager();

        accountingVp.FirstName = "Fares";
        accountingVp.LastName = "Steen";
        accountingVp.CalculatePerHourRate(4);

        Employee employee = new Manager();

        employee.FirstName = "Fadi";
        employee.LastName = "Saibah";
        employee.AssignManager(accountingVp);
        employee.CalculatePerHourRate(2);

        Console.WriteLine($"{employee.FirstName}'s salary is {employee.Salary}/hour.");
    }
}