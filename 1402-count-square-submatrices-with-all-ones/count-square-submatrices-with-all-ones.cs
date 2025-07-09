public class Solution {
    public int CountSquares(int[][] matrix) 
    {
        // 0 1 1 1
        // 1 1 2 2
        // 0 1 2 3
        var dp = new int[matrix.Count(), matrix[0].Count()];
        dp[0,0] = matrix[0][0];
        var res = 0; 
        for( int i =0 ; i< matrix.Count() ;i++)
        {
            for(int j =0; j< matrix[0].Count();j++)
            {
                if(matrix[i][j] == 0) continue;

                if(j>0 && i>0)
                {
                    var min = Math.Min(dp[i-1,j], Math.Min(dp[i-1,j-1], dp[i,j-1]));
                    dp[i,j] = matrix[i][j] + min;
                    //Console.WriteLine($"{i},{j}   : {matrix[i][j]}+ {min} = {dp[i,j]}");
                }
                else if(i>0)
                {

                    dp[i,j] = matrix[i][j];
                }
                else if(j>0)
                {
                    dp[i,j] = matrix[i][j];
                }
                res += dp[i,j] ;
            }
        } 
        for (int r = 0; r < matrix.Count(); r++)
        {
            Console.WriteLine(string.Join(" ", Enumerable.Range(0, matrix[0].Count())
                                                        .Select(c => dp[r, c])));
        }

        return res;

    }
}