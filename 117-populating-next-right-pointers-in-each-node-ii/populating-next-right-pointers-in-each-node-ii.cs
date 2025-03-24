/*
// Definition for a Node.
public class Node {
    public int val;
    public Node left;
    public Node right;
    public Node next;

    public Node() {}

    public Node(int _val) {
        val = _val;
    }

    public Node(int _val, Node _left, Node _right, Node _next) {
        val = _val;
        left = _left;
        right = _right;
        next = _next;
    }
}
*/

public class Solution {
    public Node Connect(Node root) 
    {
        if(root == null) return null;
        var q = new Queue<Node>();
        q.Enqueue(root);
        while(q.Count>0)
        {
            var cct = q.Count;
            var nodeList = new List<Node>();
            for(int i=0;i<cct;i++)
            {
                var cur = q.Dequeue();
                if(cur.left != null) q.Enqueue(cur.left);
                if(cur.right!= null) q.Enqueue(cur.right);
                nodeList.Add(cur);
            }
            for(int k =0;k<nodeList.Count-1;k++)
            {
                nodeList[k].next = nodeList[k+1];
            }
        }
        return root;
    }
}