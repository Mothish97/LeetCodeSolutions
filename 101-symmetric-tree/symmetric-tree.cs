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
    public bool IsSymmetric(TreeNode root) {
        if(root.left==null && root.right == null)
        {
            return true;
        }
        else if(root.left==null || root.right == null)
        {
            return false;
        }
        if(root.left?.val != root.right?.val){
                return false;
            }
        Queue<TreeNode> qTreeL = new Queue<TreeNode>();
        Queue<TreeNode> qTreeR = new Queue<TreeNode>();
        qTreeL.Enqueue(root.left);
        qTreeR.Enqueue(root.right);
        while(qTreeL.Count > 0 && qTreeR.Count > 0 )
        {
            var tempL = qTreeL.Dequeue();
            var tempR = qTreeR.Dequeue();


            if(tempL.left?.val != tempR.right?.val){
                return false;
            }
            if(tempR.left?.val != tempL.right?.val){
                return false;
            }

            if (tempL.left != null && tempR.right != null) {
                qTreeL.Enqueue(tempL.left);
                qTreeR.Enqueue(tempR.right);
            } else if (tempL.left != null || tempR.right != null) {
                return false;
            }

            // Enqueue the right children
            if (tempL.right != null && tempR.left != null) {
                qTreeL.Enqueue(tempL.right);
                qTreeR.Enqueue(tempR.left);
            } else if (tempL.right != null || tempR.left != null) {
                return false;
            }


        }
        return true;
    }
}