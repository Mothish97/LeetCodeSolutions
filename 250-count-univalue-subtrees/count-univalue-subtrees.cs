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
    int count = 0;
    public TreeNode dfs(TreeNode node, Dictionary<TreeNode,bool> dct)
    {
        if(node == null)
        {
            return null;
        }
        if(dct.ContainsKey(node))
        {
            return node;
        }
        var left = dfs(node.left,dct);
        var right = dfs(node.right,dct);

        if(left!= null && right != null)
        {
            if(left.val == node.val && right.val == node.val && dct[left] && dct[right])
            {
                count++;
                dct.Add(node,true);
            }
            else{
                dct.Add(node,false);
            }
        }
        else if(left!= null)
        {
            if(left.val == node.val && dct[left])
            {
                count++;
                dct.Add(node,true);
            }
            else{
                dct.Add(node,false);
            }
        }
        else if(right!= null)
        {
            if(right.val == node.val && dct[right])
            {
                count++;
                dct.Add(node,true);
            }
            else{
                dct.Add(node,false);
            }
        }
        else{
            count++;
            dct.Add(node,true);
        }
        return node;
    }
    public int CountUnivalSubtrees(TreeNode root) 
    {
        dfs(root,new Dictionary<TreeNode,bool>());
        return count;
        
    }
}