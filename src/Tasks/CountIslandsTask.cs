namespace Leetcode.Tasks;

internal class CountIslandsTask
{
    public int NumIslands(char[][] grid)
    {
        int IslandCount = 0;

        for (int i = 0; i < grid.Length; i++)
        {
            for (int j = 0; j < grid[i].Length; j++)
            {
                if (grid[i][j] == '1')
                {
                    IslandCount++;
                    ObserveIslandDfs(grid, i, j);
                }
            }
        }

        return IslandCount;
    }

    private void ObserveIslandDfs(char[][] grid, int i, int j)
    {
        if (i < 0 || i >= grid.Length || j < 0 || j >= grid[0].Length || grid[i][j] != '1')
            return;

        grid[i][j] = 'x';

        ObserveIslandDfs(grid, i - 1, j);
        ObserveIslandDfs(grid, i, j - 1);
        ObserveIslandDfs(grid, i + 1, j);
        ObserveIslandDfs(grid, i, j + 1);
    }
}