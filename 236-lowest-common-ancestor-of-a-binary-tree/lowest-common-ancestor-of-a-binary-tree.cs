/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class Solution {

    public TreeNode dfs(TreeNode root, TreeNode p, TreeNode q)
    {
        if(root == null || root == p || root == q)
        {
            return root;
        }
        var left = dfs(root.left,p,q);
        var right = dfs(root.right,p,q);
        if(left != null && right != null)
        {
            return root;
        }
        if(left!= null)
        {
            return left;
        }
        else{
            return right;
        }
    }

    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q) 
    {
        return dfs(root,p,q);    
    }
}