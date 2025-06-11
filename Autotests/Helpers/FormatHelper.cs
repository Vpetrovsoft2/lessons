namespace Autotests.Helpers;

public class FormatHelper
{
    private Random _rnd = new();

    /// <summary>
    /// Получить случайное число
    /// </summary>
    /// <param name="x">От</param>
    /// <param name="y">До</param>
    /// <returns>int</returns>
    public int GetRandomNumberInt(int x, int y) => _rnd.Next(x, y);

    /// <summary>
    /// Получить случайную строку
    /// </summary>
    /// <param name="length"></param>
    /// <param name="useDigits"></param>
    /// <param name="useSpecialChars"></param>
    /// <returns></returns>
    public string GetRandomString(int length, char useDigits = 'n', char useSpecialChars = 'n')
    {
        char[] arrayPass = new char[length];
        string pass = "";
        string s = "";
        string digits = "1234567890";
        string symbols = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
        string specialChars = "~!@#$%^&*()_+=-{}[]:;,./<>?\'\";\\";
        if (useDigits == 'y' && useSpecialChars == 'y')
        {
            s = symbols + digits + specialChars;
        }
        else if (useDigits == 'y' && useSpecialChars == 'n')
        {
            s = symbols + digits;
        }
        else if (useDigits == 'n' && useSpecialChars == 'y')
        {
            s = symbols + specialChars;
        }
        else if (useDigits == 'n' && useSpecialChars == 'n')
        {
            s = symbols;
        }
        for (int i = 0; i < length; i++)
        {
            arrayPass[i] = s[_rnd.Next(s.Length)];
        }
        pass = new string(arrayPass);
        return pass;
    }
}
