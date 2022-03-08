namespace Library;

public class Employee : BaseEmployee,IManaged
{
    public IEmployee Manager { get; set; } = null;

    public void AssignManager(IEmployee manager)
    {
        //do stuff.....
        
        Manager = manager;
    }
}