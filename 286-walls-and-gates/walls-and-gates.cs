public class Solution {
    public void WallsAndGates(int[][] rooms) 
    {
        var gates = new List<(int r,int c)>();
        for(int i = 0 ; i<rooms.Count();i++)
        {
            for(int j =0;j< rooms[0].Count();j++)
            {
                if(rooms[i][j]== 0)
                {
                    var visi = new HashSet<(int,int)>{};
                    bfs(i , j, rooms,visi);
                    visi.Clear();
                }
            }
        }       
    }

    public void bfs(int r , int c , int[][] rooms,HashSet<(int,int)> visited)
    {
        var q= new Queue<(int r,int c)>();
        q.Enqueue((r,c));
        visited.Add((r,c));
        var lvl = 0;
        while(q.Count>0)
        {
            var qc = q.Count();
            for(int i=0;i<qc;i++)
            {
                var cur = q.Dequeue();
                if(rooms[cur.r][cur.c]< lvl)
                {
                    continue;
                }
                else{
                    rooms[cur.r][cur.c] = lvl;
                }
                foreach(var n in GetNeighors(cur.r,cur.c,rooms.Count(),rooms[0].Count()))
                {
                    if(!visited.Contains(n))
                    {
                        visited.Add(n);
                        if(rooms[n.r][n.c]!= -1)
                        {
                            q.Enqueue(n);
                        }
                    }
                }
            }
            lvl++;
            
            
        }

    }

    public List<(int r,int c)> GetNeighors(int r ,int c,int totalrow, int totalCol)
    {
        var res = new List<(int,int)>();
        var dr =new int[] {-1,1,0,0};
        var dc = new int []{0,0,1,-1};
        for(int i =0; i<dr.Count();i++)
        {
            var curr = r+dr[i];
            var curc = c+dc[i];
            if(curr>=0 && curr < totalrow && curc>=0 && curc<totalCol)
            {
                res.Add((curr,curc));
            }
        }
        return res;
    }
}

// [[0,2147483647,-1,2147483647,2147483647],
// [2147483647,0,-1,2147483647,0]]

//[[0,1,-1,2,3],
//[1,0,-1,1,0]]