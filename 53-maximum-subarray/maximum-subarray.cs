public class Solution {
    public int MaxSubArray(int[] nums) 
    {
        var dp = new int[nums.Count()+1];
        dp[0]= nums[0];
        var max = nums[0];

        for(int i = 1; i < nums.Count();i++)
        {
            var pref = dp[i-1] + nums[i];
            if(pref > nums[i])
            {
                dp[i] = pref;
            }
            else{
                dp[i] = nums[i];
            }
            max = Math.Max(dp[i], max);
        }

        return max;
    }
}



