public class Solution {
    public int dfs(string s, int start , Dictionary<int,int> memo)
    {
        if(start == s.Count() )
        {
            return 1;
        }
        if(s[start] == '0') 
        { 
            return 0;
        }
        if(memo.ContainsKey(start))
        {
            return memo[start];
        }

        var ways =0;
        ways += dfs(s, start+1,memo);

        if(start+2 <= s.Count() && int.Parse(s.Substring(start, 2)) <= 26)
        {
            ways += dfs(s, start+2,memo);
        }

        memo.Add(start,ways);
        return ways;
    }
    public int NumDecodings(string s) 
    {
        return dfs(s,0,new Dictionary<int,int>());
    }
}