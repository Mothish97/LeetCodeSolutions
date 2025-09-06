public class Solution {
    public string DecodeString(string s) {
        int i =0;
        return dfs(s,ref i);
    }
    public string dfs(string s,ref int i)
    {
        var res ="";
        while(i< s.Count() && s[i] != ']')
        {
            if(!char.IsDigit(s[i]))
            {
                res += s[i].ToString();
                i++;
                continue;
            }

            var numstr ="";
            while( i < s.Count() && s[i] != '[')
            {
               numstr +=  s[i].ToString();
               i++;
            }
            int num = int.Parse(numstr);

            i++; //for [
            var st = dfs(s,ref i);
            i++; 
            
            res += string.Concat(Enumerable.Repeat(st, num));
        }
        return res;
    }
}