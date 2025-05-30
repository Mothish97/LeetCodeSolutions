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

    int max = 1;
    public int dfs(int prev, TreeNode node)
    {
        if(node== null)
        {
            return 1;
        }
        
        var left = dfs(node.val,node.left);
        var right = dfs(node.val,node.right);
        if(node.val - prev ==1)
        {
            max = Math.Max(Math.Max(left,right)+1,max);
            return Math.Max(left,right)+1;
        }
        return 1;
    }

    public int LongestConsecutive(TreeNode root) 
    {
        dfs(root.val,root);
        return max;
    }
}