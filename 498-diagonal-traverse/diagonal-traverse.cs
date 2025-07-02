public class Solution {
    public int[] FindDiagonalOrder(int[][] mat) 
    {
        var dct = new SortedDictionary<int,List<int>>();

        for(int i =0 ; i<mat.Count();i++)
        {
            for(int j=0 ; j< mat[0].Count();j++)
            {
                if(dct.ContainsKey(i+j))
                {
                    dct[i+j].Add(mat[i][j]);
                }
                else{
                    dct.Add(i+j, new List <int> {mat[i][j]});
                }
            }
        }

        var res = new List<int>();
        var rev = true;
        foreach(var d in dct)
        {
            if(!rev)
            {
                res.AddRange(d.Value);
                rev = true;
            }
            else
            {
                d.Value.Reverse();
                res.AddRange( d.Value);
                rev = false;
            }
        }
        return res.ToArray();
    }
}

        // 0,0  0,1   0,2 0,3
        // 1,0  1,1   1,2 1,3
        // 2,0  2,1   2,2 2,3
        