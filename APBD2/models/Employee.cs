namespace APBD2.models;

public class Employee : User
{
    public string EmployeeNumber { get; private set; }
    public string Department { get; private set; }
    public override int MaxActiveRentals => 5;

    public Employee(string firstName, string lastName, string employeeNumber, string department) : base(firstName, lastName)
    {
        EmployeeNumber = employeeNumber;
        Department = department;
    }
}
