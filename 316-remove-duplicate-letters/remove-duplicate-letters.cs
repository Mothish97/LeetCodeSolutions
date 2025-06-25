public class Solution {
    public string RemoveDuplicateLetters(string s) 
    {
        var dct = new Dictionary<char,int>();
        var seen = new Dictionary<char,bool>();
        var stck = new Stack<char>();
        for(int i=0 ;i< s.Count();i++)
        {
            if(dct.ContainsKey(s[i]))
            {
                dct[s[i]] = i;
            }
            else
            {
                dct.Add(s[i],i);
            }
            if(!seen.ContainsKey(s[i]))
            {
                seen.Add(s[i],false);
            }
        }
        var res = new StringBuilder();
        for(int i=0 ;i< s.Count();i++)
        {
            if(seen[s[i]]) continue;

            if(stck.Count == 0)
            {
                stck.Push(s[i]);
                seen[s[i]]= true;
            }
            else
            {
                while (stck.Count > 0 && stck.Peek() > s[i] && dct[stck.Peek()] > i)
                {
                    seen[stck.Pop()] = false;
                }
                stck.Push(s[i]);
                seen[s[i]] = true;
            } 
        }

        while (stck.Count > 0)
            res.Insert(0, stck.Pop());

        return res.ToString();
        
    }
}