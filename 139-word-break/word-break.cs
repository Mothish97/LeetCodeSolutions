public class Solution {
    public bool WordBreak(string s, IList<string> wordDict) 
    {
        var dp = new bool[s.Count()+1];
        var hsh = new HashSet<string>();
        var max = 0;
        foreach(var x in wordDict)
        {
            max = Math.Max(x.Count(),max);
            hsh.Add(x);
        }
        dp[0] = true;
        for(int i =1 ; i< dp.Count();i++)
        {
            for(int j = 1 ; j<=i && j<=max ;j++)
            { 
                //Console.WriteLine("******************");
                if(!dp[i-j] ) continue;
                Console.WriteLine($"i : {i}  j : {j}");
                var sub = s.Substring(i-j, j);
                Console.WriteLine(sub);
                if(hsh.Contains(sub))
                {
                    dp[i] = true;
                }
            }
            //Console.WriteLine("-----------------------");
        }
        return dp[dp.Count()-1];
    }
}