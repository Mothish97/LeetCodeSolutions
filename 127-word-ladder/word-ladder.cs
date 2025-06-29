public class Solution {
    public int LadderLength(string beg, string end, IList<string> lst) 
    {
        if(!lst.Contains(end))
        {
            return 0;
        }
        if(lst.Count ==1 && check(beg,end)) return 2;

        var visit = new HashSet<string>();
        var q = new Queue<string>();
        var count = 1;
        if(lst.Contains(beg))
        {
            count =0; 
            q.Enqueue(beg);
        }
        else
        {
            foreach(var d in lst)
            {
                if(check(beg,d))
                {
                    q.Enqueue(d);
                }
            }
        }



        while(q.Count>0)
        {
            var ct = q.Count();
            for(int i =0 ; i<ct;i++)
            {            
                var cur = q.Dequeue();
                visit.Add(cur);
                foreach(var item in lst)
                {
                    if(!visit.Contains(item) && check(cur,item))
                    {
                        visit.Add(item);
                        q.Enqueue(item);
                    }
                }

            }

            count++;
            if(visit.Contains(end))
            {
                return count+1;
            }
            
        }


        return 0;
        
    }

    public bool check(string str1,string str2)
    {
        var ct =0;
        for(int i =0 ; i< str1.Count();i++)
        {
            if(str1[i] != str2[i])
            {
                ct++;
            }
            if(ct>1) return false;
        }
        if(ct == 0) return false;

        return true;
    }
}