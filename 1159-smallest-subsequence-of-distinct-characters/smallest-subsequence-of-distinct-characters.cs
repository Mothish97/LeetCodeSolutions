public class Solution {
    public string SmallestSubsequence(string s) 
    {
        var dct = new Dictionary<char,int>();
        
        for(int i =0; i<s.Count();i++)
        {
            if(!dct.ContainsKey(s[i]))
            {
                dct.Add(s[i],i);
            }
            dct[s[i]] = i;
        }

        var stck = new Stack<char>();
        var inStack = new HashSet<char>();
        for(int i=0;i<s.Count();i++)
        {
            if(inStack.Contains(s[i])) continue;

            while(stck.Count()>0 && stck.Peek() > s[i] && i<dct[stck.Peek()] )
            {
                inStack.Remove(stck.Peek());
                stck.Pop();
            }
            stck.Push(s[i]);
            inStack.Add(s[i]);
        }
        string distinct = new string(stck.Reverse().Select(x => x).Distinct().ToArray());
        return distinct;
    }

 
}