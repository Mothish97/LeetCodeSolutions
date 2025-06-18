public class Solution {
    public int[][] FloodFill(int[][] image, int sr, int sc, int color)
    {
        var curColor = image[sr][sc];
        var q = new Queue<(int r, int c)>();
        var visited = new HashSet<(int, int)>();
        q.Enqueue((sr,sc));
        visited.Add((sr,sc));
        while(q.Count>0)
        {
            var cur = q.Dequeue();
            image[cur.r][cur.c] = color;
            visited.Add(cur);
            foreach(var nei in GetN(cur.r,cur.c,image.Count(),image[0].Count()))
            {
                //Console.WriteLine($"{nei.row},{nei.col} and {image[nei.row][nei.col] }" );
                if(!visited.Contains(nei) && image[nei.row][nei.col] ==curColor)
                {
                    q.Enqueue(nei);
                }
            }
           // break;
             //Console.WriteLine($"-------------------------------------" );

        }
        return image;
        
    }
    public List<(int row, int col)> GetN(int r, int c,int m , int n)
    {
        var dr = new int[] {0, 1, 0,-1};
        var dc = new int[] {-1, 0,1,0};
        var res = new  List<(int , int )> ();
        for(int i =0 ; i< dr.Count();i++)
        {
            var curr = r + dr[i];
            var curc = c + dc[i];
            if(curr>= 0 && curr<m && curc>=0 && curc<n)
            {
                res.Add((curr,curc));
            }
        }
        return res;
    }  
}