public class Solution {
    public bool CanFinish(int numCourses, int[][] prerequisites) 
    {
        if(prerequisites.Count() ==0) return true;
        var dct = new Dictionary<int,int>();
        foreach(var p in prerequisites)
        {
            if(!dct.ContainsKey(p[0]))
            {
                dct.Add(p[0],0);
            }
            if(!dct.ContainsKey(p[1]))
            {
                dct.Add(p[1],0);
            }
        }
        foreach(var p in prerequisites)
        {
            dct[p[0]]++;
        }
        var q = new Queue<int>();
        var visited = new List<int>();
        foreach(var d in dct)
        {
            if(d.Value ==0)
            {
                q.Enqueue(d.Key);
                visited.Add(d.Key);
            }
        }

        
        while(q.Count>0)
        {       
            var cur = q.Dequeue();
            foreach(var r in prerequisites)
            {
                if(r[1] == cur)
                {                           
                    dct[r[0]]--;
                    if(dct[r[0]]==0 && !visited.Contains(r[0]) )
                    {
                        
                        visited.Add(r[0]);
                        q.Enqueue(r[0]);
                    }                       
                }
            }
            if(visited.Count >= dct.Count) return true;
        } 
        if(visited.Count >= numCourses) return true;
        return false;


        
    }
}