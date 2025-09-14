/*
// Definition for a Node.
public class Node {
    public int val;
    public IList<Node> neighbors;

    public Node() {
        val = 0;
        neighbors = new List<Node>();
    }

    public Node(int _val) {
        val = _val;
        neighbors = new List<Node>();
    }

    public Node(int _val, List<Node> _neighbors) {
        val = _val;
        neighbors = _neighbors;
    }
}
*/

public class Solution {
    public Node CloneGraph(Node node) 
    {
        if(node == null) return null;
        var res = new Node(node.val);
        var q= new Queue<Node>();
        var dct = new Dictionary<int,Node>();
        dct.Add(node.val, res);
        q.Enqueue(node);

        while(q.Count()>0)
        {
            var cur = q.Dequeue();
            var parent = dct[cur.val];
            
            foreach(var n in cur.neighbors)
            {
                
                if (dct.TryGetValue(n.val, out var ndval))
                {
                    parent.neighbors.Add(ndval);
                }
                else
                {
                    //Console.WriteLine(n.val);
                    var nd = new Node(n.val);
                    dct.Add(n.val,nd);
                    parent.neighbors.Add(nd);
                    q.Enqueue(n);
                }
            }
        }

        return dct[1];

    }
}