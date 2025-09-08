public class Solution {
    public int MaximumProfit(int[] present, int[] future, int budget) 
    {
        var dp = new int[present.Count()+1,budget+1];
        var profit = new int[future.Count()];
        var zerobud =0;
        for(int i =0; i< future.Count();i++)
        {
            profit[i] = future[i] - present[i];
            if(profit[i]>0 && present[i] ==0 )
            {
                zerobud += profit[i];
            }
        }
        // if(budget ==0)
        // {
        //     return zerobud;
        // }

        for(int i =1; i<= present.Count(); i++)
        {
            for(int j =0;j<=budget;j++)
            {
                dp[i,j] = dp[i-1,j];
                if(present[i-1] <= j)
                {
                    dp[i,j] = Math.Max(dp[i,j], dp[i-1,j- present[i-1]] + profit[i-1]);
                }
            }
        }
        return dp[present.Count(),budget];
    }
    
}

 ////  0 1 2 4
//0//  0 0 0 0
//0//0 0 0 0 0
//4//0 0 4 
//4//0
//1//1
//1//2