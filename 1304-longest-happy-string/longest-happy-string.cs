public class Solution {
    public string LongestDiverseString(int a, int b, int c) {
        var res = new StringBuilder();
        var pq = new PriorityQueue<(char val,int ct),int>();
        if(a>0) pq.Enqueue(('a',a),-a);
        if(b>0) pq.Enqueue(('b',b),-b);
        if(c>0) pq.Enqueue(('c',c),-c);

        while(pq.Count>0)
        {
            var cur = pq.Dequeue();
            if(cur.ct <=0) continue;
            if(res.Length>1)
            {
                if( cur.val != res[res.Length-1])
                {
                    if(cur.ct>1)
                    {
                        res.Append(cur.val);
                        res.Append(cur.val);
                        cur.ct -=2; 
                    }
                    else{
                        res.Append(cur.val);
                        cur.ct -=1;
                    }
                }
                else if(pq.Count>0)
                {
                    var next = pq.Dequeue();
                    res.Append(next.val);
                    next.ct -=1;
                    Console.WriteLine($"next {next.ct} {next.val}");
                    if(next.ct !=0 )pq.Enqueue(next,-next.ct);
                }
                else{
                    break;
                }
                
                 pq.Enqueue(cur,-cur.ct);
            }
            else
            {
                if(cur.ct>1)
                {
                    res.Append(cur.val);
                    res.Append(cur.val);
                    cur.ct -=2;   
                }
                else{
                    res.Append(cur.val);
                    cur.ct -=1;
                }
                pq.Enqueue(cur,-cur.ct);
            }
            


        }
        return res.ToString();
    }
}