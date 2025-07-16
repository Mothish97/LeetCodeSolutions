public class Solution {
    public int MaxUncrossedLines(int[] n1, int[] n2) 
    {
        var m = n1.Count();
        var n = n2.Count();
        var dp = new int[m,n];
        for(int i = 0 ; i<m;i++)
        {
            for(int j = 0; j<n;j++)
            {
                if(i == 0 && j==0)
                {
                    if(n1[i] == n2[j]) dp[i,j] =1;
                }
                else if(i ==0)
                {
                    if(n1[i] == n2[j]) 
                    {
                        dp[i,j] = 1;
                    }
                    else{
                        dp[i,j] = Math.Max(dp[i,j-1],dp[i,j]);
                    }
                }
                else if(j ==0)
                {
                    if(n1[i] == n2[j]) 
                    {
                        dp[i,j] = 1;
                    }
                    else{
                        dp[i,j] = Math.Max(dp[i-1,j],dp[i,j]);
                    }
                }
                else
                {
                    if(n1[i] == n2[j]) 
                    {
                        var min = Math.Min(dp[i-1,j] , Math.Min(dp[i,j-1] ,dp[i-1,j-1] ));
                        dp[i,j] = min+1;
                    }
                    else{
                        var max = Math.Max(dp[i-1,j] , Math.Max(dp[i,j-1] ,dp[i-1,j-1] ));
                        dp[i,j] = max;
                    }
                }
            }
        }
        return dp[m-1,n-1];
    }
}

//   1  4  2
//1  1  1  1   
//2  1  1  2
//4  1  2  2



//   2 5 1 2 5
//10 0 0 0 0 0
//5  0 1 1 1 1
//2  
//1  
//5  
//2

//  1 3 7 1 7 5
//1 1 1 1 1 1 1
//9 1 1 1 1 1 1
//2 1 1 1 1 1 1
//5 1 1 1 1 1 2
//1 1 1 1 2 2 2