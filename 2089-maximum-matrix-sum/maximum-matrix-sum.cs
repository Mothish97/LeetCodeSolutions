public class Solution {
    public long MaxMatrixSum(int[][] mat)
    {
        var ct = mat.Count();
        var neg =0;
        var min = int.MaxValue;
        long res = 0;
        for(int i =0; i< ct;i++)
        {
            for(int j = 0; j<ct;j++)
            {
                if(mat[i][j] <0)
                {
                    neg++;
                    
                }
                var cur = Math.Abs(mat[i][j]);
                min = Math.Min(min,cur);
                res += (long) cur;
            }
            
        }

        if(neg % 2 == 0)
         return res;

        return res-min *2;

        
        
    }
}

// -1 2  3
// -1  2 3
//  -2  3 1