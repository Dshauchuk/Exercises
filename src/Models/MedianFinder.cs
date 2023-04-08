namespace Leetcode.Models;

public class MedianFinder
{
    List<int> values;

    public MedianFinder()
    {
        values = new List<int>();
    }

    public void AddNum(int num)
    {
        int position = values.BinarySearch(num);

        if (position < 0)
        {
            position = ~position;
        }

        values.Insert(position, num);
    }

    public double FindMedian()
    {
        if (values.Count % 2 == 1)
        {
            return values[values.Count / 2];
        }

        return ((double)(values[values.Count / 2 - 1] + values[values.Count / 2])) / 2;
    }
}
