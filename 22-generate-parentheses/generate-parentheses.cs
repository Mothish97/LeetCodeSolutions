public class Solution {

    public void dfs(int curLvl, int maxLvl, string curString, int open, int close,List<string> output)
    {
        if(close>open) return;
        if(curLvl == maxLvl*2 )
        {
            if(open ==close) output.Add(curString);
            return;
        }
        dfs(curLvl+1,maxLvl,curString+"(",open+1,close,output);
        dfs(curLvl+1,maxLvl,curString+")",open,close+1,output);
    }

    public IList<string> GenerateParenthesis(int n) 
    {
        var output = new List<string>();
        dfs(0, n, "", 0, 0, output);
        return output;
    }
}