public class Solution {
    public int LongestConsecutive(int[] nums) 
    {
        if(nums.Count() == 1 ) return 1;
        if(nums.Count() == 0) return 0;

        var dct = new HashSet<int>();
        var hash = new HashSet<int>();
        var count = 0;
        var num = new HashSet<int>();
        foreach(var n in nums)
        {
            num.Add(n);
        }

        ///8  10  0  2 3 5 6 8 4  5
        foreach(var val in num)
        {
            var prev = val-1;
            var next = val+1;
            dct.Add(prev);
            dct.Add(next);
        } 
        foreach(var val in num)
        {
            if(dct.Contains(val) && !hash.Contains(val))
            {
                count++;
                hash.Add(val);
            }
        }
        var pq = new PriorityQueue<int,int>();
        foreach(var val in hash)
        {
            pq.Enqueue(val, val);
        }
    
        if(count == 0)
        {
            return 1;
        }
        var res = 0;
        var resar = new List<int>();
        while(pq.Count>0)
        {
            resar.Add(pq.Dequeue());
        }
        count =0;
        for(int i =1; i<resar.Count;i++)
        {
            if(Math.Abs(resar[i] - resar[i-1]) == 1)
            {
               count++; 
            }
            else{
                count=0;
            }
            res = Math.Max(res,count);
        }
        //Console.WriteLine(hash.Count());
        return res+1;
    }
}