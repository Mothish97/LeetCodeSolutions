public class Solution {
    public int MaxProfit(int[] prices) 
    {
        var dp = new int[prices.Count()];
        var maxsofar = 0;
        for(int i =1 ;i< prices.Count();i++)
        {
        
            dp[i] = Math.Max(prices[i] - prices[i-1] + maxsofar, maxsofar);
            maxsofar = Math.Max(maxsofar,dp[i]);
            
        }
        return dp[dp.Count()-1];
    }
}