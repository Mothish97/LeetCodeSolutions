public class Solution {
    public bool WordBreak(string s, IList<string> wordDict) 
    {
        var n = s.Count();
        var dp = new bool[n+1];
        var hsh = new HashSet<string>();
        var max = 0;
        foreach(var x in wordDict)
        {
            max = Math.Max(x.Count(),max);
            hsh.Add(x);
        }
        dp[0] = true;
        for(int i =1 ; i<= n;i++)
        {
            for(int j = 1 ; j<=i && j<=max ;j++)
            { 
                if(!dp[i-j] ) continue;

                var sub = s.Substring(i-j, j);
                Console.WriteLine(sub);
                if(hsh.Contains(sub))
                {
                    dp[i] = true;
                    break;
                }
            }
            //Console.WriteLine("-----------------------");
        }
        return dp[n];
    }
}