public class Solution {
    public int CoinChange(int[] coins, int amount) 
    {
        var dp = new int[amount +1];
        for(int i =1;i<=amount;i++)
        {
            dp[i] = amount+1;
            foreach(var c in coins)
            {
                if(i-c >= 0)
                {
                    dp[i] = Math.Min(dp[i], 1+ dp[i-c]);
                }
            }

        }
        //Console.WriteLine(String.Join(",",dp));
        if(dp[amount] == amount +1) return -1;
        return dp[amount];
        
    }
}