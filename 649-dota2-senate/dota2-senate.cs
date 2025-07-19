public class Solution {
    public string PredictPartyVictory(string senate) 
    {
        var dq = new Queue<int>();
        var rq = new Queue<int>();
         int n = senate.Length;
        for(int i =0 ; i< n; i++)
        {
            if(senate[i] == 'D')
            {
                dq.Enqueue(i);
            }
            else{
                rq.Enqueue(i);
            }
        }
       
        while(dq.Count() >0 && rq.Count()>0)
        {
            var d = dq.Dequeue();
            var r = rq.Dequeue();
            if(d<r)
            {
                dq.Enqueue(d+n);
            }
            else{
                rq.Enqueue(r+n);
            }
        }


        if(rq.Count() == 0) return "Dire";
        return "Radiant";
        
    }
}

