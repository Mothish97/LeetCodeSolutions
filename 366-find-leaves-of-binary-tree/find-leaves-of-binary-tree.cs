/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */



public class Solution 
{
    public TreeNode dfs(TreeNode node, HashSet<TreeNode> dct, List<int> lst)
    {
        if(node == null || dct.Contains(node))
        {
            return null;
        }
        var left = dfs(node.left, dct,lst);
        var right = dfs(node.right,dct,lst);
        if(left == null && right == null)
        {
            dct.Add(node);
            lst.Add(node.val);
        }
        return node;
    }
    public IList<IList<int>> FindLeaves(TreeNode root)
    {
        var dct = new HashSet<TreeNode>();
        var res = new List<IList<int>>();
        while(!dct.Contains(root))
        {
            var cur = new List<int>();
            dfs(root,dct,cur);
            res.Add(cur);
        }
        
        return res;
        
    }
}