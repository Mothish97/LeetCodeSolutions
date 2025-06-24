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
    public (int rob,int skip) dfs(TreeNode node)
    {
        if(node == null)
        {
            return (0,0);
        }
        var (leftr, lefts) = dfs(node.left);
        var (rightr, rights) = dfs(node.right);
        var r =node.val+ lefts + rights;
        var s = Math.Max(lefts, leftr) + Math.Max(rightr, rights);
        return(r,s);


    }
    public int Rob(TreeNode root) 
    {
        var val = dfs(root);

        return Math.Max(val.rob,val.skip);
    }
}