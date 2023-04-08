using Leetcode.Models;

namespace Leetcode.Tasks;

internal class LowestCommonAncestorTask
{
    public TreeNode? LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
    {
        TreeNode? minNode = null;

        FindLcaDfs(root, p, q, false, false, ref minNode);

        return minNode;
    }

    private (bool, bool) FindLcaDfs(TreeNode? root, TreeNode p, TreeNode q, bool pMatched, bool qMatched, ref TreeNode? min)
    {
        if (root == null)
            return (pMatched, qMatched);

        if (pMatched && qMatched)
            return (pMatched, qMatched);

        (bool, bool) found;

        if (pMatched)
        {
            qMatched = root.val == q.val || (root.left != null && root.left.val == q.val) || (root.right != null && root.right.val == q.val);
            if (qMatched && (min == null || root.val < min.val))
            {
                return (pMatched, qMatched);
            }

            found = FindLcaDfs(root.left, p, q, true, false, ref min);
            qMatched = found.Item2;
            if (qMatched && (min == null || root.val < min.val))
            {
                return (pMatched, qMatched);
            }

            found = FindLcaDfs(root.right, p, q, true, false, ref min);
            qMatched = found.Item2;
            if (qMatched && (min == null || root.val < min.val))
            {
                return (pMatched, qMatched);
            }
        }
        else if (qMatched)
        {
            pMatched = root.val == p.val || (root.left != null && root.left.val == p.val) || (root.right != null && root.right.val == p.val);
            if (pMatched && (min == null || root.val < min.val))
            {
                return (pMatched, qMatched);
            }

            found = FindLcaDfs(root.left, p, q, false, true, ref min);
            pMatched = found.Item1;
            if (pMatched && (min == null || root.val < min.val))
            {
                return (pMatched, qMatched);
            }

            found = FindLcaDfs(root.right, p, q, false, true, ref min);
            pMatched = found.Item1;
            if (pMatched && (min == null || root.val < min.val))
            {
                return (pMatched, qMatched);
            }
        }
        else
        {
            (bool, bool) t = FindLcaDfs(root.left, p, q, root.val == p.val, root.val == q.val, ref min);
            pMatched |= t.Item1;
            qMatched |= t.Item2;

            t = FindLcaDfs(root.right, p, q, root.val == p.val, root.val == q.val, ref min);
            pMatched |= t.Item1;
            qMatched |= t.Item2;

            if (pMatched && qMatched && (min == null || root.val < min.val))
            {
                min = root;
                return (false, false);
            }
        }

        return (pMatched, qMatched);
    }
}