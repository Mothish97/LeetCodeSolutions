using System;
using System.Linq;

public class Solution {
    public int MaxSumDistinctTriplet(int[] x, int[] y) 
    {
        var res = new int[]  {-1,-1,-1};
        var ridx =  new int[] {0,0,0};
        var pq = new PriorityQueue<(int val,int idx),int>();
        for(int i=0;i<y.Count(); i++)
        {
            pq.Enqueue((y[i],i),-y[i]);
        }
        while(pq.Count>0)
        {
            var cur = pq.Dequeue();
            if(res[0] == -1)
            {
                res[0]= cur.val;
                ridx[0] = cur.idx;
            }
            else if(res[1]==-1)
            {
                if(x[cur.idx] == x[ridx[0]])
                {
                    continue;
                }
                res[1]= cur.val;
                ridx[1] = cur.idx;
            }
            else if(res[2] == -1)
            {
                if(x[cur.idx] == x[ridx[1]] || x[cur.idx] == x[ridx[0]]  )
                {
                    continue;
                }
                res[2]= cur.val;
                ridx[2] = cur.idx;
            }

            if(res[2] != -1)
            {
                //Console.WriteLine(String.Join(",", res));
                return res.Sum();
            }
        }
        return -1;

    }
}