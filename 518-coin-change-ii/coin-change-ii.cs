public class Solution {
    public int Change(int amount, int[] coins) 
    {
     var dp= new int[coins.Count()+1,amount+1];
    for (int i = 0; i <= coins.Length; i++)
        dp[i, 0] = 1;

     for(int i=1 ; i<=coins.Count();i++)
     {
        for(int j=0;j<= amount;j++)
        {
            dp[i,j] = dp[i-1,j];
            if(j - coins[i-1]>=0)
            {
                dp[i,j] +=  dp[i,j-coins[i-1]];
            }
        }
     }
     return dp[coins.Count(),amount];
        
    }
}