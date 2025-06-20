public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) 
    {
        var rows = matrix.Length;
        var cols = matrix[0].Length;
        var col =0;
        var row = rows-1;
        while(col< cols && row>=0)
        {
            var cur = matrix[row][col];
            if(cur>target)
            {
                row--;
            }
            else if(cur<target)
            {
                col++;
            }
            else{
                return true;
            }
        }
        return false;
    }
}