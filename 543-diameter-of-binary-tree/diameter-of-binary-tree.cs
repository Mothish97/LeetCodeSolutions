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
public class Solution {
    public int res =0;
    public int DiameterOfBinaryTree(TreeNode root) {
        dfs(root);
        return res-1;
    }
    public int dfs(TreeNode node)
    {
        if(node ==null)
        {
            return 0;
        }
        
        var left = dfs(node.left);
        var right = dfs(node.right);
        res = Math.Max(res ,1 +left+right );
        Console.WriteLine( 1 +left+right);

        return 1 + Math.Max(left,right);
        
        

    }
}