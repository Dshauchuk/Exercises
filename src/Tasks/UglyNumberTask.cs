namespace Leetcode.Tasks;

// 263. Ugly Number
internal class UglyNumberTask
{
    public bool IsUgly(int n)
    {
        if (n < 1)
            return false;

        if (n == 1)
            return true;

        while (n % 2 == 0)
        {
            n /= 2;
        }

        int k = 3;

        while (n != 1)
        {
            if (k > 5)
                return false;

            if (n % k == 0)
            {
                if (k != 3 && k != 5)
                    return false;
                else
                    n /= k;
            }
            else
                k += 2;
        }

        return true;
    }
}