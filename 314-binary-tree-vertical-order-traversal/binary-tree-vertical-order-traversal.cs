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
    public IList<IList<int>> VerticalOrder(TreeNode root) 
    {
        if(root == null)
        {
            return new List<IList<int>>();
        }
        var q = new Queue<(TreeNode n,int c)>();
        var dct = new SortedDictionary<int,List<int>>();
        q.Enqueue((root,0));
        while(q.Count>0)
        {
            var cur = q.Dequeue();
            if(dct.ContainsKey(cur.c))
            {
                dct[cur.c].Add(cur.n.val);
            }
            else
            {
                dct.Add(cur.c, new List<int>(){cur.n.val});
            }

            if(cur.n.left!= null)
            {
                q.Enqueue((cur.n.left,cur.c-1));
            }
            if(cur.n.right!= null)
            {
                q.Enqueue((cur.n.right,cur.c+1));
            }
        }
        List<IList<int>> res = new List<IList<int>>();
        foreach(var d in dct)
        {
            res.Add(d.Value);
        }
        return res;
    }
}