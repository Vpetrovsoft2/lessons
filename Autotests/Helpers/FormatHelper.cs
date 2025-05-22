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
}
