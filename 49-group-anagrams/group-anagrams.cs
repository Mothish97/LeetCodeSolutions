public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) 
    {       
        var dct = new Dictionary<string,List<string>>();
        var sorted = new List<string>();
        var res = new List<IList<string>>();
        foreach(var s in strs)
        {
            var c = s.ToCharArray();
            Array.Sort(c);
            sorted.Add(new string(c));
        }
        for(int i=0; i < sorted.Count;i++)
        {
            if(dct.ContainsKey(sorted[i]))
            {
                dct[sorted[i]].Add(strs[i]);
            }
            else
            {
                dct.Add(sorted[i],new List<string>(){strs[i]});
            }
        }
        foreach(var d in dct.Values)
        {
            res.Add(d);
        }
        

 
        return res;

    }

}