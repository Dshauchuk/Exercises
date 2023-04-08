namespace Leetcode.Tasks;

// 509. Fibonacci Number
internal class FibonacciTask
{
    public int Fib(int n)
    {
        int n1 = -1, n2 = 0, x = 0;

        for (int i = 0; i <= n; i++)
        {
            if (n1 == -1)
                n1 = i;
            else if (n2 == 0)
                n2 = i;
            else
            {
                x = n2;
                n2 += n1;
                n1 = x;
            }
        }
        return n2;
    }
}