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
    float max = 0.0f;
    public (float ct, float sum) dfs(TreeNode node)
    {
        if(node == null)
        {
            return (0.0f,0.0f);
        }
        var left = dfs(node.left);
        var right = dfs(node.right);
        float total = (float)node.val+(float) left.sum + (float)right.sum;
        float count = 1.0f + (float)left.ct + (float)right.ct; 
        max =Math.Max(total/count,max);
        return(count,total);
    }
    public double MaximumAverageSubtree(TreeNode root) 
    {
        dfs(root);
        return max;
    }
}