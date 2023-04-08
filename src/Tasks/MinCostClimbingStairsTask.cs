namespace Leetcode.Tasks;

// 746. Min Cost Climbing Stairs
internal class MinCostClimbingStairsTask
{
    public int MinCostClimbingStairs(int[] cost)
    {
        int[] totalCost = new int[cost.Length + 1];

        totalCost[0] = totalCost[1] = 0;

        for (int i = 2; i <= cost.Length; i++)
        {
            totalCost[i] = Math.Min(totalCost[i - 1] + cost[i - 1], totalCost[i - 2] + cost[i - 2]);
        }

        return totalCost[cost.Length];
    }
}