public class Solution {
    public long MaxKelements(int[] nums, int k) 
    {
        var pq = new PriorityQueue<int,int>();
        foreach(var n in nums)
        {
            pq.Enqueue(n,-n);
        }
        long res = 0;
        var kused= 0;
        while( kused <k)
        {
            var cur = pq.Dequeue();
            res+= (long)cur;
            var n = Math.Ceiling((double)cur/(double)3);
            pq.Enqueue((int)n,(int)-n);
            kused++;
        }
        return res;
        
    }
}