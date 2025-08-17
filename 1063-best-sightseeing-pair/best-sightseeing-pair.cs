public class Solution {
    public int MaxScoreSightseeingPair(int[] val)
    {
        var dp =new int[val.Count()];
        var max = val[0];
        var ind =0;
        dp[0] = val[0];
        //Console.WriteLine(string.Join(",",dp));
        for(int i=1; i<dp.Count();i++)
        {
            for(int j =i-1; j>ind;j--)
            {
                if(val[j] -j+i >=max )
                {
                    max =val[j];
                    ind =j;
                    break;
                }
            }
            dp[i] = Math.Max(dp[i-1], val[i] + max + ind - i);
            if(max <= val[i])
            {
                ind = i;
                max = val[i];
            }   
            //Console.WriteLine(string.Join(",",dp));
        }
       


        return dp.Max();
    }
}
//[ 8 1 5 2 6]
//[ 0 0 0 0 0 0]
//[ 8 8 11   ]