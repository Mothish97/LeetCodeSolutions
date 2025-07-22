public class Solution {
    public int Rob(int[] nums) 
    {
        if(nums.Count() ==1) return nums[0];
        var dp = new int[nums.Count()];
        var dp2 = new int[nums.Count()+1];
        dp[1] = nums[0];
        dp2[1] = nums[1];
        for(int i =2; i<dp.Count();i++)
        {
            dp[i] = Math.Max(dp[i-1], nums[i-1]+dp[i-2]);
        }
        for(int i =2; i<dp.Count();i++)
        {
            dp2[i] = Math.Max(dp2[i-1], nums[i]+dp2[i-2]);
        }

        Console.WriteLine(string.Join(",",dp));
        Console.WriteLine(string.Join(",",dp2));
        return Math.Max(dp.Max(), dp2.Max());

    }
}
