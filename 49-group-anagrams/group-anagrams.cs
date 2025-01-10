public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs)
    {
        var res = new List<IList<string>>();
        var dct = new Dictionary<string,List<string>>();

        foreach(var st in strs)
        {
            string sorted = new string(st.OrderBy(c => c).ToArray());
            if(dct.ContainsKey(sorted))
            {
                dct[sorted].Add(st);
            }
            else
            {
                dct.Add(sorted, new List<string>{st});
            }
        }
        foreach(var d in dct)
        {
            res.Add(d.Value);
        }
        return res;
    }
}