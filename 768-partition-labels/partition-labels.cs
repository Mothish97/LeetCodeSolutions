public class Solution {
    public IList<int> PartitionLabels(string s) 
    {

        var res = new List<int>();
        var dct = new Dictionary<char,int>();
        
        for(int i =0 ; i< s.Count();i++)
        {
            if (dct.TryGetValue(s[i], out _))
            {
                dct[s[i]] = i;      // key exists – overwrite the value
            }
            else
            {
                dct.Add(s[i], i);   // key missing – add it
            }
        }

        var curLast = 0;
        for(int i =0 ; i< s.Count();i++)
        {
            curLast = Math.Max(curLast,dct[s[i]]);
            if(dct[s[i]] == i && i >= curLast)
            {
                res.Add(i);
            }
        }
        for(int i =res.Count()-1;i>0;i--)
        {
            res[i] = res[i] - res[i-1];
        }
        res[0]++;
        //Console.WriteLine(string.Join(",", res));

        return res;

        
    }
}


