public class Solution {
    public string PredictPartyVictory(string senate) 
    {
        var dq = new Queue<int>();
        var rq = new Queue<int>();
        var blocked = new HashSet<int>();
        var indices = new List<int>();
        for(int i =0 ; i< senate.Count(); i++)
        {
            indices.Add(i);
            if(senate[i] == 'D')
            {
                dq.Enqueue(i);
            }
            else{
                rq.Enqueue(i);
            }
        }
        if(rq.Count() == 0) return "Dire";
        if(dq.Count()==0) return "Radiant";

        var ind =0;
        while(ind < indices.Count() )
        {
            var l  = indices[ind];
            //Console.WriteLine(string.Join(",",indices));
            //Console.WriteLine(indices[ind]);
            if(senate[indices[ind]] == 'D' )
            {
                var last = dq.Dequeue();
                dq.Enqueue(last);
                var toBlock = rq.Dequeue();
                // Console.WriteLine("---");
                indices.Remove(toBlock);
                if(toBlock < l) ind--;
                // Console.WriteLine("---");
                if(rq.Count == 0) return "Dire";
            }
            else if(senate[indices[ind]] == 'R' )
            {
                var last = rq.Dequeue();
                rq.Enqueue(last);
                var toBlock = dq.Dequeue();
                if(toBlock < l) ind--;
                indices.Remove(toBlock);
                if(dq.Count == 0) return "Radiant";
            }
            // Console.WriteLine("---");
            ind++;
            if(ind >= indices.Count())
            {
                // Console.WriteLine("---");
                ind =0;
                // Console.WriteLine($"dq.Count() {dq.Count()}   rq.Count(){ rq.Count()}");
                // if(dq.Count()> rq.Count()) return "Dire";
                // if(dq.Count()< rq.Count()) return "Radiant";
                // if(dq.Count() == rq.Count() ) ind =0;
            }
        }

        return "";
        
    }
}

