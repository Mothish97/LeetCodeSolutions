/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class Solution 
{
    public TreeNode dfs(TreeNode node, TreeNode p, TreeNode q)
    {
        if(node == null || node == p || node == q)
        {
            return node;
        }
        var left = dfs(node.left,p,q);
        var right = dfs(node.right,p,q);
        if(left != null && right != null)
        {
            return node;
        }
        else if(left != null)
        {
            return left;
        }
        else if ( right!= null)
        {
            return right;
        }

        return null;
    }

    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q) 
    {
        
        return dfs(root,p,q);
    }
}