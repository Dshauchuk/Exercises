namespace Leetcode.Extensions;
public static class ArrayExtensions
{
    public static void PrintInline<T>(this T[] array)
    {
        Console.WriteLine(string.Join(",", array));
    }

    public static void PrintVertically<T>(this T[] array)
    {
        foreach (T item in array)
            Console.WriteLine(item);
    }

    public static void PopulateFromConsole<T>(this T[] array)
    {
        if (array.Length == 0)
            return;

        Console.WriteLine($"Enter {array.Length} values of {typeof(T).Name} type: ");

        for (int i = 0; i < array.Length; i++)
        {
            T? value = default;

            while (!Console.ReadLine()?.TryParse<T>(out value) ?? false)
            {
                Console.WriteLine("Invalid value, please input a number: ");
            }

            if (value != null)
                array[i] = value;
        }
    }
}