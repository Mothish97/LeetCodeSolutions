public class Solution {
    public void Rotate(int[][] matrix) 
    {
         int n = matrix.Count();
        for (int i = 0; i < n; i++)
        {
            for (int j = i + 1; j < n; j++)
            {
                // Swap matrix[i,j] and matrix[j,i]
                int temp = matrix[i] [j];
                matrix[i] [j] = matrix[j][ i];
                matrix[j] [i] = temp;
            }
        }
        foreach(var dat in matrix)
        {
            Array.Reverse(dat);
        }
        
    }
}