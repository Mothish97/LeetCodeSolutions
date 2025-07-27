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
    public Dictionary<int,int> dct = new Dictionary<int,int>();
    public int ct = 0;
    public TreeNode BuildTree(int[] preorder, int[] inorder) 
    {

        for(int i =0; i<inorder.Count();i++)
        {
            dct.Add(inorder[i],i);
        }
        return dfs(0,preorder.Count()-1,preorder);
    }

    public TreeNode dfs(int l, int r, int[] pre)
    {
        if(l>r)
        {
            return null;
        }
        var val = pre[ct++];
        var root = new TreeNode(val);
        var mid = dct[val];
        root.left = dfs(l,mid-1,pre);
        root.right = dfs(mid+1,r,pre);
        return root;
    }
}