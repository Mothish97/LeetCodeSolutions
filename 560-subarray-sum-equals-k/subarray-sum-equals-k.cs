public class Solution {
    public int SubarraySum(int[] nums, int k) 
    {
        var dct = new Dictionary<int,int>();
        dct[0] = 1;
        var sum =0;
        var count = 0; 
        foreach(var n in nums)
        {
            sum = sum+n;
            var diff = sum-k;
            if(dct.ContainsKey(diff))
            {
                count = count + dct[diff];
            }
            if(!dct.ContainsKey(sum))
            {
                dct.Add(sum,0);
            }
            dct[sum]++;
    
        }
        return count;
        
    }
}