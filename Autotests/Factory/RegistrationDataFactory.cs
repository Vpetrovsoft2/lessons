namespace Autotests.Factory;

public class RegistrationDataFactory
{
    public RegistrationDataFactory(
        string firstName = "Вася",
        string lastName = "Петечкин",
        string userName = "Король",
        string password = "Test123")
    {
        FirstName = firstName;
        LastName = lastName;
        UserName = userName;
        Password = password;
    }

    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string UserName { get; set; }
    public string Password { get; set; }
}
