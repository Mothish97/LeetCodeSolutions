public class Solution {
    public long MaximumImportance(int n, int[][] roads) 
    {
        var freq = new Dictionary<int,int>();
        var city = new Dictionary<int,int>();
        for(int i =0;i<n;i++)
        {
            freq.Add(i,0);
        }
        foreach(var r in roads)
        {
            freq[r[0]]++;
            freq[r[1]]++;
        }

        var sort = freq.OrderByDescending(pair => pair.Value);
        var cur = n;
        foreach(var d in sort)
        {
            //Console.WriteLine($"for {d.Key} with freq {d.Value} added {n}");
            city.Add(d.Key,n--);
            if(n <0) n =0;
        }
        long res =0;

        foreach(var r in roads)
        {
            res+= (long) city[r[0]] + (long)city[r[1]];
        }
        return res;
    }
}