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
        int n = senate.Length;
        while(dq.Count() >0 && rq.Count()>0)
        {
            var d = dq.Dequeue();
            var r = rq.Dequeue();
            if(d<r)
            {
                dq.Enqueue(d+n );
            }
            else{
                rq.Enqueue(r+n );
            }
        }


        if(rq.Count() == 0) return "Dire";
        if(dq.Count()==0) return "Radiant";
        return "";
        
    }
}

