public class Solution {
    public int[] TopKFrequent(int[] nums, int k)
    {
        var pq = new PriorityQueue<int,int>(Comparer<int>.Create((a,b)=> b-a));
        var dct = new Dictionary<int,int>();
        foreach(var n in nums)
        {
            if(dct.ContainsKey(n)) 
            {
                dct[n]++;
            }else{
                dct[n] =1;
            }
        }
        foreach(var d in dct){
            pq.Enqueue(d.Key,d.Value);
        }
        int g =0;
        var res = new int[k];
        while(g<k)
        {
            var dq = pq.Dequeue();
            res[g] = dq;
            g++;
        }
        return res;

    }
}