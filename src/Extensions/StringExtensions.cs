namespace Leetcode.Extensions;
public static class StringExtensions
{
    public static bool TryParse<T>(this string value, out T? result)
    {
        try
        {
            if (string.IsNullOrEmpty(value))
            {
                result = default;
                return false;
            }

            result = (T)Convert.ChangeType(value, typeof(T));
            return true;
        }
        catch (Exception ex)
        {
            System.Console.WriteLine(ex);
            result = default;
            return false;
        }
    }
}