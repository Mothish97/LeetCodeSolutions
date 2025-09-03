public class Solution {
    public void SetZeroes(int[][] mat) 
    {
        var hr = new HashSet<int>();
        var hc = new HashSet<int>();
        var m = mat.Count();
        var n = mat[0].Count();

        for(int r =0 ; r<m;r++)
        {   
            for(int c =0; c<n; c++)
            {
                if(mat[r][c] == 0)
                {
                    hc.Add(c);
                    hr.Add(r);
                }
            }
        }

        foreach(var a in hr)
        {
            for(int c =0 ; c<n; c++)
            {
                mat[a][c] = 0;
            }
        }

        foreach(var b in hc)
        {
            for(int r =0 ; r<m; r++)
            {
                mat[r][b] = 0;
            }
        }



    }
}

//1 0 1
//1 1 1
//1 1 1