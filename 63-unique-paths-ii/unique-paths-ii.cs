public class Solution 
{
    public int UniquePathsWithObstacles(int[][] obs)
    {
        var m = obs.Count();
        var n = obs[0].Count(); 
        if(obs[0][0] == 1 ) return 0;
        if( m == 1 && n == 1 && obs[m-1][n-1] == 1) return 0;
        var matrix = new int[m,n];
        matrix[0,0] =1;
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {        
                if(obs[i][j]== 1) continue ;    
                if(j>0 && i>0 )
                {
                    matrix[i,j] = matrix[i-1,j] + matrix[i,j-1];
                }
                else if(j>0)
                {
                    matrix[i,j] =  matrix[i,j-1];
                }
                else if(i>0)
                {
                    matrix[i,j] =  matrix[i-1,j];
                }
                //Console.Write(matrix[i, j]);
            }
             //Console.WriteLine();
        }
        return matrix[m-1,n-1];
    }
}