public class Solution {
    public int FindMinFibonacciNumbers(int k) 
    {
        var lst = new List<int>();
        lst.Add(1);
        lst.Add(1);
        while(lst[lst.Count()-1]<=k)
        {
            lst.Add(lst[lst.Count()-1] + lst[lst.Count()-2]);
        }
        lst.RemoveAt(lst.Count()-1);
        Console.WriteLine(string.Join(",",lst));

        lst.Reverse();
        var res =0;
        foreach(var s in lst)
        {
            //Console.WriteLine($"k {k} - s {s} = {k-s} ");
            if(k-s >=0)
            {
                k = k-s;
                res++;
            }
            if(k == 0)
            {
                return res;
            }
        }
        return res;
        

        return 0;
        
    }
}