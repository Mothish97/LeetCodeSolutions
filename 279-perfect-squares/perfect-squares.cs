public class Solution {
    public int NumSquares(int n) 
    {
        var q = new Queue<int>();
        q.Enqueue(n);
        var visted =new HashSet<int>();
        var ct = 0;
        while(q.Count>0)
        {
            var qt= q.Count();
            for(int i =0 ;i< qt;i++)
            {
                var cur = q.Dequeue();
                if(cur == 0) return ct;
                foreach(var c in GetN(cur))
                {
                    if(!visted.Contains(cur-c))
                    {
                        q.Enqueue(cur-c);
                        visted.Add(cur-c);
                    }  
                }
            }
            ct++;

        }

        return ct;
    }

    public List<int> GetN(int n)
    {
        var res = new List<int>();
        for(int i =0 ; i<= n ; i++)
        {
            if(i*i <= n)
            {
                res.Add(i*i );
            }
            else{
                break;
            }
        }
        return res;
    }
}