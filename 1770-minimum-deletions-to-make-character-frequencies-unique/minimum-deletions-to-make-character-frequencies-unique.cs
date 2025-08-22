public class Solution {
    public int MinDeletions(string s) {
        var dct=  new Dictionary<char,int>();
        var hsh = new HashSet<int>();
        var ind = 1;
        foreach(var c in s)
        {
            if(!dct.ContainsKey(c))
            {
                dct.Add(c,0);
            }
            dct[c]++;
        }
        var arr = dct.Values.OrderBy(v => v).ToList();
        Console.WriteLine(string.Join(",",arr));
        var avai = 1;
        var res = 0;
        for(int i =1; i< arr.Count();i++)
        {
            if(arr[i] == arr[i-1])
            {
                var cur = arr[i-1];
                var diff= 0;
                while(cur >0 )
                {
                    cur--;
                    diff++;
                    if(!hsh.Contains(cur))
                    {
                       break;
                    }
                }
                hsh.Add(cur);
                res+= diff;


            }
            else
            {
                hsh.Add(arr[i-1]);
            }
        }
        return res;
    }
}