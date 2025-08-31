public class Solution {
    public int CountQuadruples(string fir, string sec) 
    {
        var dct1 = new Dictionary<int, int>();
        var dct2 = new Dictionary<int,int>();
        int n = fir.Length, m = sec.Length;

        for(int i =0; i<n;i++)
        {
            dct1.TryAdd(fir[i], i);
        }
        for(int j =0; j<m;j++)
        {
            dct2[sec[j]] = j;
        }
        int minDiff = int.MaxValue;
        var ct = 0;

        foreach(var k in dct1)
        {
            var j = k.Value;
            if (!dct2.TryGetValue(k.Key, out int a)) continue; 

            if(minDiff > (j-a))
            {
                ct=1;
                minDiff = j-a;
            }
            else if(minDiff == (j-a)){
                ct ++;
            }
        }


        return ct;
    }
}