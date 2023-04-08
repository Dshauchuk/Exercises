using Leetcode.Models;

namespace Leetcode.Tasks;

// 98. Validate Binary Search Tree
internal class ValidateBinarySearchTreeTask
{
    public bool IsValidBST(TreeNode root)
    {
        return IsSubtreeValidDfs(root, long.MinValue, long.MaxValue);
    }

    private bool IsSubtreeValidDfs(TreeNode root, long min, long max)
    {
        if (root == null)
            return true;

        if (root.left != null && (root.left.val <= min || root.left.val >= root.val || !IsSubtreeValidDfs(root.left, min, (long)root.val)))
            return false;

        if (root.right != null && (root.right.val <= root.val || root.right.val >= max || !IsSubtreeValidDfs(root.right, (long)root.val, max)))
            return false;

        return true;
    }
}