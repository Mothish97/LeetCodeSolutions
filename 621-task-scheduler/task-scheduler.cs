public class Solution {
    public int LeastInterval(char[] tasks, int n) 
    {
        var pq = new PriorityQueue<char,int>();
        var cool = new  Dictionary<char,int>();
        var tsk = new Dictionary<char,int>();
        foreach(var c in tasks)
        {
            if(!tsk.ContainsKey(c))
            {
                tsk.Add(c,0);
            }
            tsk[c]++;
        }
        foreach(var d in tsk)
        {
            pq.Enqueue(d.Key,-d.Value);
        }
        var res =0;
        while(pq.Count>0)
        {       
            res++;
            var cur = pq.Dequeue();
            foreach(var d in cool)
            {
                cool[d.Key]--;
                if(cool[d.Key] == 0)
                {
                    if(tsk.ContainsKey(d.Key) && tsk[d.Key]>0)
                    {
                        pq.Enqueue(d.Key,-tsk[d.Key]);
                    }
                        
                    cool.Remove(d.Key);
                }
            }
            tsk[cur]--;
            if(tsk[cur] == 0)
            {
                tsk.Remove(cur);
            } 
            else{
                cool.Add(cur,n);
            }

            while(pq.Count ==0 && cool.Count() >0)
            {
                res++;
                foreach(var d in cool)
                {
                    cool[d.Key]--;
                    if(cool[d.Key] <= 0)
                    {
                        if(tsk.ContainsKey(d.Key) && tsk[d.Key]>0)
                        {
                            pq.Enqueue(d.Key,-tsk[d.Key]);
                        }
                        
                        cool.Remove(d.Key);
                    }
                }
            }

            
        }

        return res;



    }
}