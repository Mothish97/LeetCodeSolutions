public class Solution 
{
    public int dfs(int[,] mat, int[,] memo,int r, int c)
    {
        int rows = mat.GetLength(0);
        int cols = mat.GetLength(1);

        if (r >= rows || c >= cols)
            return 0;

        if(memo[r,c] != -1)
        {
            return memo[r,c];
        }
        if(mat[r,c] == 0)
        {
            return 0;
        }

        var down =dfs(mat,memo,r+1,c);
        var right = dfs(mat,memo,r,c+1);
        var diag = dfs(mat,memo,r+1,c+1);
        memo[r,c] =  1 + Math.Min(diag,Math.Min(right,down));
        return memo[r,c] ;
    }
    public int MaximalSquare(char[][] matrix) 
    {
        var mat = new int[matrix.Count(),matrix[0].Count()];
        var memo = new int[matrix.Count(),matrix[0].Count()];
        for(int i =0; i< matrix.Count();i++)
        {
            for(int j=0;j<matrix[0].Count();j++)
            {
                mat[i,j] = matrix[i][j] - '0';
                memo[i,j] = -1;
            }
        }
                int rows = matrix.Length;
        int cols = matrix[0].Length;

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                if (mat[i, j] == 1)
                {
                    dfs(mat,memo, i, j);
                }
            }
        }
        var maxSize = 0;
        for(int i = 0; i < rows; i++)
        {
            for(int j = 0; j < cols; j++)
            {
                if (mat[i,j] == 1)
                {
                    maxSize = Math.Max(maxSize,memo[i,j] );
                }
            }
        }
        return maxSize* maxSize;
    }
}