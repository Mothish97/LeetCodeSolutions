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
    public TreeNode dfs(TreeNode node, TreeNode[] nodes)
    {
        if(node == null)
        {
            return null;
        }
        if(nodes.Contains(node)) return node;
        var left = dfs(node.left,nodes);
        var right = dfs(node.right,nodes);
        if(left!= null && right != null) return node  ;  

        return left??right;

    }
    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode[] nodes) 
    {
        return dfs(root,nodes);
    }
}