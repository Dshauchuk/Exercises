using Leetcode.Models;

namespace Leetcode.Tasks;

// 102. Binary Tree Level Order Traversal
internal class BinaryTreeLevelOrderTraversalTask
{
    public IList<IList<int>> LevelOrder(TreeNode root)
    {
        IList<IList<int>> values = new List<IList<int>>();

        if (root == null)
            return values;

        Queue<List<TreeNode>> queue = new Queue<List<TreeNode>>();
        List<TreeNode> tmp;

        queue.Enqueue(new List<TreeNode> { root });
        values.Add(new List<int> { root.val });

        while (queue.Count > 0)
        {
            tmp = queue.Dequeue();

            if (tmp != null && tmp.Any())
            {
                List<int> childrenValues = new List<int>();
                List<TreeNode> children = new List<TreeNode>();

                foreach (var node in tmp)
                {
                    if (node.left != null)
                    {
                        childrenValues.Add(node.left.val);
                        children.Add(node.left);
                    }

                    if (node.right != null)
                    {
                        childrenValues.Add(node.right.val);
                        children.Add(node.right);

                    }
                }

                if (children.Any())
                    queue.Enqueue(children);

                if (childrenValues.Any())
                    values.Add(childrenValues);
            }
        }

        return values;
    }
}