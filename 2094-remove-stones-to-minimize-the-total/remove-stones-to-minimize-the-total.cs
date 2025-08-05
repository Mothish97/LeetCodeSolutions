public class Solution {
    public int MinStoneSum(int[] piles, int k) 
    {
        var pq = new PriorityQueue<int,int>();
        foreach(var p in piles)
        {
            pq.Enqueue(p,-p);
        }
        var kused = 0;
        while(kused<k && pq.Count>0)
        {
            var cur  = pq.Dequeue();
            var mid = Math.Floor((Double)cur/2);
            var rem = (int)cur -(int)mid;
            if(rem >0) pq.Enqueue(rem,-rem);
            kused++;
        }
        var res =0;
        while(pq.Count>0)
        {
            res+= pq.Dequeue();
        }
        return res;
    }
}