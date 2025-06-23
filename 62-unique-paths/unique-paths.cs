public class Solution {
    public int UniquePaths(int m, int n) 
    {
                // WRITE YOUR BRILLIANT CODE HERE
        var col = n;
        n = m; 
        m= col;
        int[,] matrix = new int[m, n]; 
        matrix[0,0] =1;

        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {                
                if(j>0 && i>0)
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