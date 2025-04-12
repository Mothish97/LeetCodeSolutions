public class Solution {
    public IList<int> CountSteppingNumbers(int low, int high)
    {
        var q = new Queue<long>();
        var res = new List<int>();
        if(low == 0)
        {
            res.Add(low);
            low++;

        }
        for(int i =1;i<=9;i++)
        {
            q.Enqueue(i);
        }
        while(q.Count>0)
        {
            var cur = q.Dequeue();
            if (cur > high) continue;
            if(cur>= low)
            {
                res.Add((int)cur);
            }

            var last = cur%10;
            if(last>0)
            {
                var next = cur * 10+ (last-1);
                if (next <= high)
                    q.Enqueue(next);

                
            }
            if(last<9)
            {
                var next = cur * 10+ (last+1);
                if (next <= high)
                    q.Enqueue(next);
                
            }
        }
        res.Sort();
        return res;
        
    }
}