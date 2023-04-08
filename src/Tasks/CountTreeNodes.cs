using Leetcode.Models;

namespace Leetcode.Tasks;

// 222. Count Complete Tree Nodes
internal class CountTreeNodesTask
{
    public int CountNodes(TreeNode? root)
    {
        if (root == null)
            return 0;

        int leftHeight = CountLeftHeight(root);
        int rightHeight = CountRightHeight(root);

        if (leftHeight == rightHeight)
            return (int)Math.Pow(2, leftHeight) - 1;

        var l = CountNodes(root.left);
        var r = CountNodes(root.right);

        return l + r + 1;
    }

    private int CountLeftHeight(TreeNode? leftNode)
    {
        if (leftNode == null)
            return 0;

        int heigth = 0;

        while (leftNode != null)
        {
            heigth++;
            leftNode = leftNode.left;
        }

        return heigth;
    }

    private int CountRightHeight(TreeNode? rightNode)
    {
        if (rightNode == null)
            return 0;

        int heigth = 0;

        while (rightNode != null)
        {
            heigth++;
            rightNode = rightNode.right;
        }

        return heigth;
    }
}