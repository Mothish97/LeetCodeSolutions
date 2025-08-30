public class Solution {
    public int MaxSubArray(int[] nums) 
    {
        var dp = new int[nums.Count()+1];
        dp[0]= nums[0];
        var max = nums[0];

        for(int i = 1; i < nums.Count();i++)
        {
            var cur = Math.Max(nums[i],dp[i-1]+nums[i]);
            max = Math.Max(max,cur);
            dp[i] = cur;
        }

        return max;
    }
}



