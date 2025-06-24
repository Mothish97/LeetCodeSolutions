public class Solution {
    public int MinDistance(string word1, string word2) 
    {
        if(word1 == "") return word2.Count();
        if(word2 == "") return word1.Count();
        var dp = new int[word1.Count()+1,word2.Count()+1];
        for(int i =0 ;i<=word2.Count();i++)
        {
            dp[0,i]=i;
        }
        for(int i =0 ;i<=word1.Count();i++)
        {
            dp[i,0]=i;
        }


        for(int i = 1;i<=word1.Count();i++)
        {
            for(int j =1 ;j<= word2.Count();j++)
            {
                if(word1[i-1] == word2[j-1])
                {
                    dp[i,j] = dp[i-1,j-1];
                }
                else
                {
                    dp[i,j] = 1 + Math.Min(dp[i-1,j],Math.Min(dp[i-1,j-1],dp[i,j-1]));
                }
            }
        }

        return dp[word1.Count(),word2.Count()];
    }
}