namespace Autotests.Factory;

public class AddUserWebTableFactory
{
    public AddUserWebTableFactory(
        string firstName = "Vanysha",
        string lastName = "Golikov",
        string age = "12",
        string email = "test@gamil.com",
        string salary = "15000",
        string department = "Policia")
    {
        FirstName = firstName;
        LastName = lastName;
        Age = age;
        Email = email;
        Salary = salary;
        Department = department;
    }

    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Age { get; set; }
    public string Email { get; set; }
    public string Salary { get; set; }
    public string Department { get; set; }
}
