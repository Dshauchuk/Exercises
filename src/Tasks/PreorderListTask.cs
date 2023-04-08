using System.Collections.Generic;
using System.Linq;
using Leetcode.Models;

namespace Leetcode.Tasks;

internal class PreorderListTask
{
    public IList<int> Preorder(Node root)
    {
        if (root == null)
            return new List<int>(0);

        List<int> rootValues = new List<int>() { root.val };

        if (root.children != null && root.children.Any())
        {
            foreach (var node in root.children)
            {
                rootValues.AddRange(Preorder(node));
            }
        }

        return rootValues;
    }
}