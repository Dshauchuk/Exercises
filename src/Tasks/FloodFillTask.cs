namespace Leetcode.Tasks;

// 733. Flood Fill
internal class FloodFillTask
{
    public int[][] FloodFill(int[][] image, int sr, int sc, int color)
    {
        int m = image.Length;
        int n = image[0].Length;
        int x, y;

        HashSet<(int, int)> visited = new HashSet<(int, int)>();

        Stack<(int, int)> stack = new Stack<(int, int)>();
        stack.Push((sr, sc));

        while (stack.Count > 0)
        {
            (int, int) current = stack.Pop();

            if (visited.Contains(current))
                continue;

            int prevColor = image[current.Item1][current.Item2];
            image[current.Item1][current.Item2] = color;
            visited.Add(current);

            x = current.Item1 - 1;
            y = current.Item2;
            if (x >= 0 && x < m && image[x][y] == prevColor && !visited.Contains((x, y)))
                stack.Push((x, y));

            x = current.Item1 + 1;
            if (x >= 0 && x < m && image[x][y] == prevColor && !visited.Contains((x, y)))
                stack.Push((x, y));

            x = current.Item1;
            y = current.Item2 - 1;
            if (y >= 0 && y < n && image[x][y] == prevColor && !visited.Contains((x, y)))
                stack.Push((x, y));

            y = current.Item2 + 1;
            if (y >= 0 && y < n && image[x][y] == prevColor && !visited.Contains((x, y)))
                stack.Push((x, y));
        }

        return image;
    }
}