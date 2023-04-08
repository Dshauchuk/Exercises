namespace Leetcode.Models;

public class Point
{
    public int X;
    public int Y;

    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }

    public override bool Equals(object? obj)
    {
        if (obj == null)
            return false;

        if (obj is Point another)
        {
            return another.X == X && another.Y == Y;
        }
        else
            return false;
    }

    public override int GetHashCode()
    {
        return base.GetHashCode();
    }
}
