public class Solution {
    public int NumIslands(char[][] grid) 
    {
        var visited = new HashSet<(int, int)>();
        var oneLocation  = new HashSet<(int, int)>();
        var result =0;
        for(int r =0; r< grid.Length; r++)
        {
            for(int c = 0; c< grid[r].Length;c++)
            {
                if(grid[r][c]=='1')
                {
                    oneLocation.Add((r,c) );
                }

            }
        }
        if(oneLocation.Count ==0 ) return 0;
        var st = new Queue<(int,int)>();
        var firstElement = oneLocation.First();
        st.Enqueue(firstElement);
        visited.Add(firstElement);
        oneLocation.Remove(firstElement);
        while(st.Count>0)
        {
            var curQ = st.Count;

            var (x,y) = st.Dequeue(); 
            var nei = GetNeighbors(x,y,grid);
            for(int i=0; i< nei.Count;i++)
            {
                var(nx,ny) = nei[i];
                var location = (nx,ny);
                if(!visited.Contains(location))
                {
                    visited.Add(location);
                    if(grid[nx][ny]=='1')
                    {
                        st.Enqueue((nx,ny));
                        oneLocation.Remove(location);
                    }
                }
            }


            if(st.Count ==0 && oneLocation.Count>0)
            {
                var f = oneLocation.First();
                result++;
                st.Enqueue(f);
                oneLocation.Remove(f);
            }
            
 
        }
        return result+1;
    }

    public List<(int,int)> GetNeighbors(int row, int col,char[][] grid)
    {
        var dx = new List<int> (){1,-1,0,0};
        var dy = new List<int> (){0,0,1,-1};
        var result = new List<(int,int)>();
        for(int i =0;i<dx.Count;i++)
        {
            int curRow = row+dx[i];
            int curCol = col+dy[i];
            if((curCol >=0 && curCol<grid[0].Length) && (curRow >=0 && curRow<grid.Length) )
            {
                result.Add((curRow,curCol));
            }
        }
        return result;
    }
}