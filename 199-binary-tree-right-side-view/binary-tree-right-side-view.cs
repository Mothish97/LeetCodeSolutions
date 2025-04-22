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
    public IList<int> RightSideView(TreeNode root)
    {
        if(root == null) return new List<int>(){};
        var q = new Queue<TreeNode>();
        q.Enqueue(root);
        var res = new List<int>();
        while(q.Count>0)
        {
           
            var qCt = q.Count;
            for(int i =0; i< qCt;i++)
            {
                var curQ = q.Dequeue();
                if(curQ.left!=null)
                {
                    q.Enqueue(curQ.left);
                }
                if(curQ.right != null)
                {
                    q.Enqueue(curQ.right);
                }

                if(i == qCt-1)
                {
                    res.Add(curQ.val);
                }
                                        
            }
           
        }
        return res;
    }
}