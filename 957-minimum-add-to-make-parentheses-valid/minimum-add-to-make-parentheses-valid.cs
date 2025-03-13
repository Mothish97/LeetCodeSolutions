public class Solution {
    public int MinAddToMakeValid(string s) 
    {
        var res = 0;
        var open = 0;
        foreach(var c in s)
        {
            if(c=='(')
            {
                open++;
            }
            else if(c==')')
            {
                open--;
            }
            if(open<0)
            {
                res++;
                open =0;
            }
        }
        return res + open;

    }
}