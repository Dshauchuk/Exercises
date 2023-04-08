namespace Leetcode.Models;

public class StockSpanner
{
    int[] store;
    int iterator = 0;

    public StockSpanner()
    {
        store = new int[10000];
    }

    public int Next(int price)
    {
        store[iterator++] = price;

        return GetSpan(price);
    }


    private int GetSpan(int value)
    {
        int count = 0, i = iterator - 1;

        while (i >= 0 && store[i] <= value)
        {
            count++;
            i--;
        }

        return count;
    }
}
