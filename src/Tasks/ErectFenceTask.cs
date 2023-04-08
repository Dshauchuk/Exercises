using Leetcode.Models;

namespace Leetcode.Tasks;

// 587. Erect the Fence
internal class ErectFenceTask
{
    #region v1

    public int[][] OuterTrees(int[][] trees)
    {
        if (trees.Length < 3)
            return trees;

        // all fence-points gonna be stored here
        HashSet<int> fencePoints = new HashSet<int>();

        // p - the current point, l - leftmost, q - next, n - number of all proposed points
        int p, l = 0, q, n = trees.Length;

        // find the left(and bottom)most point
        for (int i = 1; i < n; i++)
            if (trees[i][0] < trees[l][0] || (trees[i][0] == trees[l][0] && trees[i][1] < trees[l][1]))
                l = i;

        p = l;

        do
        {
            q = (p + 1) % n;

            // point that are on the same line
            List<int> collinear = new List<int>();

            for (int i = 0; i < n; i++)
            {
                if (i == p)
                    continue;

                // calc the orientation
                int orientation = Orientation(trees[p], trees[i], trees[q]);

                // if the point is on the same line - take all them as "collinear" points and set the farest one to q var
                if (orientation == 0)
                {
                    if (GetDistance(trees[p], trees[i]) > GetDistance(trees[p], trees[q]))
                    {
                        collinear.Add(q);
                        q = i;
                    }
                    else
                        collinear.Add(i);
                }
                else if (orientation == 2)
                {
                    q = i;
                    collinear.Clear();
                }
            }

            p = q;
            fencePoints.Add(p);

            if (collinear.Any())
            {
                foreach (var c in collinear)
                    fencePoints.Add(c);
            }

        }
        while (p != l);

        return fencePoints.Select(a => trees[a]).ToArray();
    }

    private static double GetDistance(int[] p, int[] q)
    {
        return Math.Sqrt(Math.Pow(Math.Abs(q[0] - p[0]), 2) + Math.Pow(Math.Abs(q[1] - p[1]), 2));
    }

    private static int Orientation(int[] p, int[] q, int[] r)
    {
        int value = (q[1] - p[1]) * (r[0] - q[0]) -
            (r[1] - q[1]) * (q[0] - p[0]);

        if (value == 0)
            return 0;

        return value > 0 ? 1 : 2;
    }


    #endregion

    #region v2

    // learning...
    // https://www.geeksforgeeks.org/convex-hull-set-1-jarviss-algorithm-or-wrapping/?ref=gcse
    public Point[] ErectFence(Point[] points)
    {
        if (points.Length < 3)
            return points;

        List<Point> fencePoints = new List<Point>();

        int p, l = 0, q, n = points.Length;
        for (int i = 1; i < points.Length; i++)
        {
            if (points[i].X < points[l].X)
                l = i;
        }

        p = l;
        do
        {
            fencePoints.Add(points[p]);

            q = (p + 1) % n;

            for (int i = 0; i < n; i++)
            {
                if (Orientation(points[p], points[i], points[q]) != 1)
                    q = i;
            }

            p = q;
        }
        while (p != l);

        return fencePoints.ToArray();
    }

    // 0 - line
    // 1 - clockwise
    // 2 - counterclokwice
    private static int Orientation(Point p, Point q, Point r)
    {
        int value = (q.Y - p.Y) * (r.X - q.X) -
            (r.Y - q.Y) * (q.X - p.X);

        if (value == 0)
            return 0;

        return value > 0 ? 1 : 2;
    }

    #endregion
}