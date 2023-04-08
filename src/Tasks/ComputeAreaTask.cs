namespace Leetcode.Tasks;

internal class ComputeAreaTask
{
    public int ComputeArea(int ax1, int ay1, int ax2, int ay2, int bx1, int by1, int bx2, int by2)
    {
        if (!DoOverlap(ax1, ay1, ax2, ay2, bx1, by1, bx2, by2))
        {
            return ((ax2 - ax1) * (ay2 - ay1)) + ((bx2 - bx1) * (by2 - by1));
        }
        else
        {
            return ((ax2 - ax1) * (ay2 - ay1)) + ((bx2 - bx1) * (by2 - by1)) - ((Math.Min(ay2, by2) - Math.Max(ay1, by1)) * (Math.Min(ax2, bx2) - Math.Max(ax1, bx1)));
        }
    }

    private bool DoOverlap(int ax1, int ay1, int ax2, int ay2, int bx1, int by1, int bx2, int by2)
    {
        if (ax1 == ax2 || ay1 == ay2 || bx1 == bx2 || by1 == by2)
            return false;

        if (ay1 >= by2 || ay2 <= by1)
            return false;

        if (ax2 <= bx1 || ax1 >= bx2)
            return false;

        return true;
    }

}