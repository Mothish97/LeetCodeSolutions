public class Solution {
    public int MaxFrequency(int[] nums, int k) 
    {
        var freq = new HashSet<int>();
        var numk = 0;
        foreach(var n in nums)
        {
            if(n == k)
            {
                numk++;
            }
            
            freq.Add(n);  
            
        }
        var res = 0;

        foreach(var f in freq)
        {
            var cur = 0;
            var max = 0;
            for(int i =0 ;i<nums.Count();i++)
            {
                if(nums[i] == k) cur--;
                if(nums[i] == f) cur++;
                if(cur <0) cur = 0;
                max = Math.Max(max,cur + numk);
            }
            res = Math.Max(res,max);
            
        }
        return res;
    }
}