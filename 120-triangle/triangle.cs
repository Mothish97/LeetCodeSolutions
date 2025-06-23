public class Solution {

    public static int dfs(List<List<int>> tri,int x, int y, int[,] memo)
    {
        if(x>= tri.Count || y>= tri[x].Count)
        {
            return 0;
        }
        if(memo[x,y]!=  int.MaxValue)
        {
            return memo[x,y];
        }
        var left = dfs(tri,x+1,y,memo);
        var right = dfs(tri,x+1,y+1,memo);
        memo[x, y] = tri[x][y] + Math.Min(left, right);
        return tri[x][y] + Math.Min(left,right);
    }

    public int MinimumTotal(IList<IList<int>> triangle) 
    {
        int[,] memo = new int[triangle.Count,triangle.Count];
        var tri = triangle.Select(row => row.ToList()).ToList();
   
        int rows = memo.GetLength(0);
        int cols = memo.GetLength(1);
        for (int i = 0; i < rows; i++)
            for (int j = 0; j <cols; j++)
                memo[i, j] = int.MaxValue;

        return dfs(tri,0,0,memo);
        
    }
}