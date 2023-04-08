namespace Leetcode.Tasks;

// 62. Unique Paths
internal class UniquePathsTask
{
    public int UniquePaths(int m, int n)
    {
        int[,] desk = new int[m, n];

        for (int i = 0; i < m; i++)
            desk[i, 0] = 1;

        for (int i = 0; i < n; i++)
            desk[0, i] = 1;

        for (int i = 1; i < m; i++)
        {
            for (int j = 1; j < n; j++)
            {
                desk[i, j] = desk[i, j - 1] + desk[i - 1, j];
            }
        }

        return desk[m - 1, n - 1];
    }
}
