public class Solution {
    public long MostPoints(int[][] ques) 
    {
        var dp = new long [ques.Count()+1];
        for(int i = 0; i<ques.Count();i++ )
        {

            if(i>0)
            {
                dp[i] = Math.Max(dp[i-1],dp[i]);
            }
            if(i + ques[i][1]+1 < ques.Count())
            {
                dp[i + ques[i][1]+1] = Math.Max((long)dp[i + ques[i][1]+1]  ,(long) dp[i] +(long) ques[i][0]);
            }
            else{
                dp[ques.Count()] = Math.Max((long)dp[ques.Count()] , (long)dp[i] +(long) ques[i][0]);
            }
            //Console.WriteLine(string.Join(",",dp));
        }
        //Console.WriteLine(string.Join(",",dp));
        return dp.Max();
        
    }
}