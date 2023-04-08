namespace Leetcode.Tasks;

// 374. Guess Number Higher or Lower
internal class GuessNumberTask
{
    public int GuessNumber(int n)
    {
        int min = 1;
        int max = n;

        while (min <= max)
        {
            long t = ((long)min + (long)max) / 2;
            int mid = (int)t;

            int flag = Guess(mid);

            if (flag == 0)
                return mid;

            if (flag == -1)
                max = mid - 1;
            else
                min = mid + 1;
        }

        return -1;
    }

    private static int Guess(int n)
    {
        int x = 1702766719;

        return n == x ? 0 : n > x ? -1 : 1;
    }
}