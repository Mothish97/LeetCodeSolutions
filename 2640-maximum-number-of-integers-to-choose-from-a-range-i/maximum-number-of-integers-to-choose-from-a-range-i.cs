public class Solution {
    public int MaxCount(int[] banned, int n, int maxSum) 
    {
        var dct = new HashSet<int>();
        foreach(var d in banned)
        {
            dct.Add(d);
        }
        var res = 0;
        var val =0;
        for(int i = 1; i<=n; i++)
        {
            if(!dct.Contains(i) && res+i<= maxSum)
            {
                res +=i;
                val++;
            }
            if(res+i > maxSum) return val;
        }
        return val;
    }
}

//1 2 3 4 5
//5 