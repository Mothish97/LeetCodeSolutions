public class Solution {
    public int Rob(int[] nums) 
    {
        var dp = new int[nums.Count()+1];

        for(int i=1; i<= nums.Count();i++)
        {
            if(i<3)
            {
                dp[i] = nums[i-1];
            }
            else
            {
                var max = 0;
                for(int j=0 ; j<i-1;j++)
                {
                    max = Math.Max(dp[j],max);
                }
                dp[i] = nums[i-1] + max;

            }

        }
        Console.WriteLine(String.Join(",",dp));

        return dp.Max();
        
    }
}