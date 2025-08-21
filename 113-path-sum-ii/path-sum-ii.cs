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
    public List<int> path = new List<int>();
    public List<IList<int>> res = new  List<IList<int>> ();
    public IList<IList<int>> PathSum(TreeNode root, int targetSum) {
        dfs(root,targetSum,0);
        return res;
    }
    public void dfs(TreeNode node, int tar, int sum)
    {
        if(node == null)
        {
            return;
        }

        path.Add(node.val);
        if(node.left == null && node.right == null)
        {
            if(path.Sum() == tar)
            {
                res.Add(new List<int>(path));
            }
        }
        else{
            dfs(node.left,tar,0);
            dfs(node.right,tar,0);
        }
        // else if (node.right != null)
        // {
        //     dfs(node.left,tar , sum+ node.right.val);
        //     path.RemoveAt(path.Count()-1);
        // }
        path.RemoveAt(path.Count()-1);
        
    }

}