public class Solution {
    public bool CanConstruct(string s, int k) 
    {
        if(k == s.Count()) return true;
        if(k > s.Count()) return false;
        var kused =k;
        var dct = new Dictionary<char,int>();
        foreach(var c in s)
        {
            if(!dct.ContainsKey(c))
            {
                dct.Add(c,0);
            }
            dct[c]++;
        }
        if(dct.Count()==1) return true;

        foreach(var d in dct)
        {
            if(d.Value %2 !=0)
            {
                kused--;
                if(kused ==-1) return false;
            }
        }

        
        return true;
        
    }
}

// a 2
// n 2
// b 1
// e 2
// l 2
