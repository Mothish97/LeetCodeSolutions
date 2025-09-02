public class Solution 
{
    public HashSet<(int row,int col)> replace = new HashSet<(int row,int col)> ();
    public HashSet<(int row,int col)> banned = new HashSet<(int row,int col)> ();
    public int m = 0;
    public int n = 0;
    public void Solve(char[][] brd) 
    {
        m = brd.Count();
        n = brd[0].Count();
        var os = new HashSet<(int,int)>();
        for(int i =0; i<m;i++)
        {
            for(int j =0;j<n ;j++)
            {
                if(brd[i][j]=='O' && i != m -1 && j!= n -1 && i!=0 && j!=0 && !banned.Contains((i,j)))
                {
                    bfs(i,j, brd);
                }
            }
        }
        foreach(var r in  replace)
        {
            Console.WriteLine($"({r.row},{r.col})");
            brd[r.row][r.col] = 'X';
        }
        
    }

    public void bfs(int r, int c,char[][] brd)
    {
        if(replace.Contains((r,c))) return;
        var visited = new HashSet<(int,int)> ();
        var q = new Queue<(int row,int col)>();
        q.Enqueue((r,c));
        var currep =  new HashSet<(int,int)> ();
        currep.Add((r,c));
        visited.Add((r,c));
        while(q.Count>0)
        {
            var qct = q.Count();
            for(int i =0; i<qct; i++)
            {
                var cur = q.Dequeue();
                foreach(var nb in GetNeighbor(cur.row,cur.col))
                {
                    if(!visited.Contains((nb.row,nb.col)))
                    {
                        visited.Add((nb.row,nb.col));
                        if(brd[nb.row][nb.col] == 'O' && !replace.Contains((nb.row,nb.col)))
                        {
                            if(nb.row > 0 && nb.col > 0 && nb.row < m-1 && nb.col < n-1)
                            {
                                q.Enqueue((nb.row,nb.col));
                                
                                currep.Add((nb.row,nb.col));
                            }
                            else{
                                banned.UnionWith(currep);
                                return;
                            }
                        }
                    }
                }
            }
            
        }

        replace.UnionWith(currep);

    }

    public List<(int row,int col)> GetNeighbor(int r,int c )
    {
        var dr =new List<int>() {1,-1,0,0};
        var dc =new List<int>(){0,0,1,-1};
        var res = new List<(int,int)>();
        for(int i =0 ;i<4;i++)
        {
            var newr = dr[i] + r;
            var newx = dc[i] + c;
            if(newr < m && newx< n && newr>=0 && newx>=0)
            {
                res.Add((newr,newx));
            }
        }
        return res;
    }
}

// ["O","X","X","O","X"],
// ["X","O","O","X","O"],
// ["X","O","X","O","X"],
// ["O","X","O","O","O"],
// ["X","X","O","X","O"]]