namespace Autotests.Factory;

public class AddUserWebTableFactory
{
    public string FirstName
    {
        get
        {
            return DI.FormatHelper.GetRandomString(7);
        }
        set
        {
            FirstName = value;
        }
    }
    public string LastName
    {
        get
        {
            return DI.FormatHelper.GetRandomString(8);
        }
        set
        {
            LastName = value;
        }
    }
    public string Age
    {
        get
        {
            return DI.FormatHelper.GetRandomNumberInt(18, 90).ToString();
        }
        set
        {
            Age = value;
        }
    }
    public string Email
    {
        get
        {
            return DI.FormatHelper.GetRandomString(8) + "@gmail.com";
        }
        set
        {
            Email = value;
        }
    }
    public string Salary
    {
        get
        {
            return DI.FormatHelper.GetRandomNumberInt(15000, 100000).ToString();
        }
        set
        {
            Salary = value;
        }
    }
    public string Department
    {
        get
        {
            return DI.FormatHelper.GetRandomString(8);
        }
        set
        {
            LastName = value;
        }
    }
}