public class Solution {
    public string MinRemoveToMakeValid(string s) 
    {
        var ar = s.ToCharArray();
        var stck = new Stack<(char data,int idx)>();
        for(int i =0 ;i<ar.Count();i++)
        {
            if(ar[i] == '(')
            {
                stck.Push((ar[i],i));
            }
            else if(ar[i] == ')')
            {
                if(stck.Count()>0)
                {
                    stck.Pop();
                }
                else
                {
                    ar[i]= ' ';
                }
            }
        }
        while(stck.Count>0)
        {
            var cur = stck.Pop();
            ar[cur.idx]=' ';
        }
        var res = new StringBuilder();
        foreach(var c in ar)
        {
            if(c != ' ')
            {
                res.Append(c);
            }
            
        }
        return res.ToString();
    }
}