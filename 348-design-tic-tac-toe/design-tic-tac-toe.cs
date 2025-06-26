public class TicTacToe 
{
    public List<List<int>> map;
    public TicTacToe(int n) 
    {
        map = new List<List<int>> ();
        for(int i =0; i<n ;i++)
        {
            var row = new List<int>();
            for(int j=0 ;j<n;j++)
            {
                row.Add(0);
            }
            map.Add(row);
        }
    }
    
    public int Move(int row, int col, int player) 
    {
        if(map[row][col] == 0)
        {
            map[row][col] = player;
            if(CheckIfWon(row,  col, player))
            {
                return player;
            }
        }
        return 0;
        
    }

    public bool CheckIfWon(int row, int col, int player)
    {
        var isHor = true;
        var isVer =true;
        var isDiag=true;
        var isDiagR = true;
        for(int i =0; i< map.Count;i++)
        {
            if(map[i][col] != player)
            {
                isVer = false;
                break;
            }
        }


        for(int i =0; i< map.Count;i++)
        {
            if(map[row][i] != player)
            {
                isHor = false;
                break;
            }

        }

        for(int i =0; i< map.Count; i++)
        {
            if(map[i][i] != player)
            {
                isDiag = false;
                break;
            }
        }

        for(int i =0; i< map.Count; i++)
        {
            if(map[i][map.Count -1 -i] != player)
            {
                isDiagR = false;
                break;
            }
        }




        return isDiag || isHor || isVer || isDiagR;

    }
}

/**
 * Your TicTacToe object will be instantiated and called as such:
 * TicTacToe obj = new TicTacToe(n);
 * int param_1 = obj.Move(row,col,player);
 */