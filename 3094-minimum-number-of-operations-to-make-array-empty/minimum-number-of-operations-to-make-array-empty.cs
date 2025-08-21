public class Solution {
    public int MinOperations(int[] nums) 
    {
        var freq = new Dictionary<int,int>();
        foreach(var n in nums)
        {
            if(!freq.ContainsKey(n))
            {
                freq.Add(n,0);
            }
            freq[n]++;
        }

        var dct = new Dictionary<int,int>();
        var f = freq.Values.OrderBy(v => v).ToList();
        var res = 0;
        foreach(var n in f)
        {
            if(dct.ContainsKey(n))
            {
                res+= dct[n];
                continue;
            }
            var cur = n;
            var op =0;

            while(cur>0)
            {
                if(cur - 3 != 1  && cur-3 >=0)
                {
                    cur -=3;
                }
                else if(cur-2 != 1  && cur-2 >=0)
                {
                    cur -= 2;
                }
                else{
                    return -1;
                }
                op++;
            }
            dct.Add(n,op);
            res+= op;
        }
        return res;
        
    }
}

//8 -> 5 -> 2 -> 2
//7 -> 4 -> 