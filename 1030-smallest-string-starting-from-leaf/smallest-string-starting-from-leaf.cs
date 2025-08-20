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
    private string best = null!;
    private readonly List<char> path = new List<char>();
    public string SmallestFromLeaf(TreeNode root) 
    {   
        dfs(root);
        return best ?? "";
    }

    private void dfs(TreeNode node)
    {
        if (node == null) return;

        path.Add((char)('a' + node.val));

        if(node.left == null && node.right == null)
        {
            var ct = path.Count();
            var buf = new StringBuilder();
            for(int i =  ct-1; i>=0 ;i--)
            {
                buf.Append(path[i].ToString());
            }

            if(best == null  ||  string.Compare(buf.ToString(), best, StringComparison.Ordinal) < 0)
            {
                best = buf.ToString();
            }
        }
        else{
            dfs(node.left);
            dfs(node.right);
        }
        path.RemoveAt(path.Count()-1);
    }
}