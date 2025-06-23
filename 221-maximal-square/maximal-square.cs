public class Solution {

    public static int dfs(int[,] mat, int r, int c, int[,] map)
    {
        int rows = map.GetLength(0);
        int cols = map.GetLength(1);

        if (r >= rows || c >= cols)
            return 0;
        if(map[r,c]!= -1)
        {
            return map[r,c];
        }
        if(mat[r,c] == 0)
        {
            return 0;
        }
        var down = dfs(mat,r+1,c,map);
        var right = dfs(mat,r,c+1,map);
        var diag = dfs(mat,r+1,c+1,map);
        
        map[r,c] = Math.Min(down,Math.Min(right,diag))+1;
        return map[r,c];

    }
    public int MaximalSquare(char[][] matrix) {
        
        if(matrix.Length == 0 || matrix[0].Length == 0) return 0;
    
        int rows = matrix.Length;
        int cols = matrix[0].Length;
        int maxSize = 0;
        int[,] memo = new int[rows, cols];
        int[,] mat = new int[rows, cols];

        for(int i = 0; i < rows; i++)
        {
            for(int j = 0; j < cols; j++)
            {
                memo[i,j] = -1;
                mat[i,j] = matrix[i][j] - '0';
            }
        }

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                if (mat[i, j] == 1)
                {
                    dfs(mat, i, j, memo);
                }
            }
        }

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
        // Return the size of the largest square found.
        return maxSize*maxSize;
    }
}