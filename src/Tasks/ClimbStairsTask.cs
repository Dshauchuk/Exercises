namespace Leetcode.Tasks;

// 70. Climbing Stairs
internal class CLimbStairsTask
{
    public int ClimbStairs(int n)
    {
        n++;

        if (n < 2)
            return n;

        int n1 = 0, n2 = 1, n3 = 0;

        for (int i = 1; i < n; i++)
        {
            n3 = n1 + n2;
            n1 = n2;
            n2 = n3;
        }

        return n3;
    }
}