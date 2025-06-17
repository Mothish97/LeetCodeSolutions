public class Solution 
{
    public int[] FindOrder(int numCourses, int[][] prerequisites) 
    {
        var dct = new Dictionary<int,int>();
        var q= new Queue<int>();
        var visited = new List<int>();
        for(int i =0; i<numCourses ; i++)
        {
            dct.TryAdd(i,0);
        }

        foreach(var data in prerequisites)
        {
            dct[data[0]]++;
        }
        foreach(var d in dct)
        {
            if(d.Value == 0)
            {
                q.Enqueue(d.Key);
                visited.Add(d.Key);
            }
        }
        if(visited.Count==0  && prerequisites.Length>0) return [];
        while(q.Count>0)
        {
            var cur = q.Dequeue();
            foreach(var  req in prerequisites)
            {
                if(req[1]== cur)
                {
                    dct[req[0]]--;
                    if(dct[req[0]] < 0) return [];
                    if(dct[req[0]] == 0 && !visited.Contains(req[0]) )
                    {
                        q.Enqueue(req[0]);
                        visited.Add(req[0]);
                    }
                    
                }
            }
            if(visited.Count == numCourses) return visited.ToArray();
            
        }
        if(visited.Count > 0) return [];
        return visited.ToArray();
        
    }
}