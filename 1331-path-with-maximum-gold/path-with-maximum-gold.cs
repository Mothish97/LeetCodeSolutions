public class Solution {
    public int GetMaximumGold(int[][] grid) 
    {
        var res = 0;
        var memo = new Dictionary<(int,int),int>();
        for(int i =0; i< grid.Count();i++)
        {
            for(int j=0; j< grid[0].Count();j++)
            {
                memo.Clear();
                if(grid[i][j]>0)
                {
                    res = Math.Max(res,dfs(grid,i,j,memo));
                }
            }
        }
        return res;
    }
    public int dfs(int[][] grid,int r,int c, Dictionary<(int,int),int> memo)
    {
        //Console.WriteLine($"{r} {c}");
        if(r<0 || r>=grid.Count() || c<0 || c>=grid[0].Count())
        {
            return 0;
        }
        if(grid[r][c] == 0)
        {
            return 0;
        }
        var cur =  grid[r][c];
        grid[r][c]=0;
        var left = dfs(grid,r-1,c,memo);
        var up = dfs(grid,r,c+1,memo);
        var down = dfs(grid,r,c-1,memo);
        var right = dfs(grid,r+1,c,memo);
       
        var max = cur+  Math.Max(left,Math.Max(right,Math.Max(up,down)));
        grid[r][c]  = cur;
        return max;
    }
}

//[1,0,7],
//[2,0,6],
//[3,5,6],
//[4,3,1],
