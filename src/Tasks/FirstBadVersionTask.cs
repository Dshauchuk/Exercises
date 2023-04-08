namespace Leetcode.Tasks;

// 278. First Bad Version
internal class FirstBadVersionTask
{
    public int FirstBadVersion(int n)
    {
        int minNum = 0;
        int maxNum = int.MaxValue;

        while (minNum <= maxNum)
        {
            int mid = (int)(((uint)minNum + (uint)maxNum) / 2);

            bool isBad = IsBadVersion(mid);

            if (isBad)
            {
                if (!IsBadVersion(mid - 1))
                    return mid;
                else
                    maxNum = mid - 1;
            }
            else
            {
                minNum = mid + 1;
            }
        }

        return -1;
    }

    private static bool IsBadVersion(int n)
    {
        return n >= 1702766719;
    }
}