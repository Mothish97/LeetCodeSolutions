public class Solution {
    public int Rob(int[] nums) 
    {
        var dp = new int[nums.Count()+1];

        dp[1]= nums[0];
        for(int i=2; i<= nums.Count();i++)
        {
            dp[i] = Math.Max(dp[i-1], dp[i-2]+ nums[i-1]);
        }
        Console.WriteLine(String.Join(",",dp));

        return dp.Max();
        
    }
}