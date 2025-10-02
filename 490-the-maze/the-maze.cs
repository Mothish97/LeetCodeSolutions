public class Solution {
     
    public bool HasPath(int[][] maze, int[] start, int[] dest) 
    {
        HashSet<(int r, int c)> visited = new HashSet<(int r, int c)>();
        var dr =new int []{1,-1,0,0};
        var dc = new int []{0,0,1,-1};
        var m = maze.Count();
        var n = maze[0].Count();
        var q = new Queue<(int r, int c)>();
        q.Enqueue((start[0],start[1]));
        visited.Add((start[0],start[1]));
        while(q.Count()>0)
        {
            var qct = q.Count();
            for(int i =0; i<qct ;i++)
            {
                var cur = q.Dequeue();
                
                var row = cur.r;
                var col = cur.c;
                if(row == dest[0] && col == dest[1]) return true;
                while(row< m-1 && maze[row+1][col] == 0 )
                {
                    row++;
                }

                if(!visited.Contains((row,col)))
                {
                    visited.Add((row,col));
                    q.Enqueue((row,col));
                }
                row = cur.r;
                col = cur.c;


                while(row>0 && maze[row-1][col] == 0 )
                {
                    row--;
                }
                if(!visited.Contains((row,col)))
                {
                    visited.Add((row,col));
                    q.Enqueue((row,col));
                }
                row = cur.r;
                col = cur.c;


                while(col< n-1 && maze[row][col+1] == 0 )
                {
                    col++;
                }
                if(!visited.Contains((row,col)))
                {
                    visited.Add((row,col));
                    q.Enqueue((row,col));
                }
                row = cur.r;
                col = cur.c;

                while(col>0 && maze[row][col-1] == 0 )
                {
                    col--;
                }
                if(!visited.Contains((row,col)))
                {
                    visited.Add((row,col));
                    q.Enqueue((row,col));
                }
            }
            
        }


        return false;
    } 

}