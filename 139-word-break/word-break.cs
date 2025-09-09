public class Solution {
    public bool WordBreak(string s, IList<string> wordDict) {
        var set = new HashSet<string>(wordDict);
        int n = s.Length;
        var dp = new bool[n+1];
        dp[0] = true;
        var max = int.MinValue;
        foreach(var x in set)
        {
            max = Math.Max(max,x.Count());
        }

        for(int i =1; i<=n ;i++)
        {
            for(int j = 1; j<= max && j<=i;j++)
            {
                if(!dp[i-j])  continue;

                if(set.Contains(s.Substring(i-j, j)))
                {
                    dp[i] = true;
                    break;
                }
            }
        }
        return dp[n];
    }
}