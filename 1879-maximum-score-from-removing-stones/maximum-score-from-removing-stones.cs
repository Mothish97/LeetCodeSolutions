public class Solution {
    public int MaximumScore(int a, int b, int c) 
    {
        var pq = new PriorityQueue<int , int>();
        var res =0;
        pq.Enqueue(a,-a);
        pq.Enqueue(b,-b);
        pq.Enqueue(c,-c);

        while(pq.Count>1)
        {
            var f = pq.Dequeue();
            var s = pq.Dequeue();
            f--;
            s--;
            if(f>0) pq.Enqueue(f,-f);
            if(s>0) pq.Enqueue(s,-s);
            res++;
        }
        return res;
    }
}


