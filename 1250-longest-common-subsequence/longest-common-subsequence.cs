public class Solution {
    public int LongestCommonSubsequence(string text1, string text2)
    {
        var m = text1.Count();
        var n = text2.Count();
        var dp = new int[m+1,n+1];
        for(int i =1; i<m+1;i++)
        {
            for(int j =1; j<n+1;j++)
            {
                var max = Math.Max(dp[i-1,j], dp[i,j-1]);
                if(text1[i-1] == text2[j-1] )
                {                  
                    max = dp[i-1,j-1] +1;
                }
                dp[i,j]= max;
               // Console.Write($"{dp[i, j]} "); 
            }
            //Console.WriteLine(); 
        }


        return dp[m,n];
    } 
    
    
    }
    //      a  b  c  d  e  
    //   0  0  0  0  0  0
    // a 0  1  1  1  1  1
    // c 0  1  1  2  2  2
    // e 0  1  1  2  2  3


        //    j m j k b k j k v   
        //  0 0 0 0 0 0 0 0 0 0 
        //b 0 0 0 0 0 1 1 1 1 1
        //s 0 0 0 0 0 1 1 1 1 1 
        //b 0 0 0 0 0 1 1 1 1 1 
        //i 0 0 0 0 0 0 1 1 1 1 
        //n 0 0 0 0 0 0 1 1 1 1
        //i 0 0 0 0 0 0 1 1 1 1
        //u 0 0 0 0 0 0 1 1 1 1
        //m 0 0 0 0 0 0 1 1 1 1

