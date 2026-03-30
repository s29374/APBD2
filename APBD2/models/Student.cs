namespace APBD2.models;

public class Student : User
{
    public string Major { get; private set; }
    public string StudentNumber { get; private set; }
    public override int MaxActiveRentals => 2;

    public Student(string firstName, string lastName, string studentNumber, string major) : base(firstName, lastName)
    {
        StudentNumber = studentNumber;
        Major = major;
    }
}
