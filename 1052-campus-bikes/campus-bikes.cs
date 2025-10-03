public class Solution {
    public int[] AssignBikes(int[][] worker, int[][] bikes) 
    {
        var pq = new PriorityQueue<(int wrk, int bike, int dist), (int dist,int wrk, int bike )>();
        var m = worker.Count();
        var n = bikes.Count();
        for(int i =0; i<m;i++)
        {
            for(int j=0; j<n;j++)
            {
                var dis =Math.Abs(worker[i][0]- bikes[j][0]) +  Math.Abs(worker[i][1]- bikes[j][1]);
                pq.Enqueue((i,j,dis),(dis,i,j));   
            }
        }
        var wrks = new HashSet<int>();
        var bike = new HashSet<int>();
        var res = new int[m];
        Array.Fill(res,-1);
        while(pq.Count>0)
        {
            var cur = pq.Dequeue();
            if(res[cur.wrk] == -1  && !bike.Contains(cur.bike) )
            {
                res[cur.wrk] = cur.bike;
                bike.Add(cur.bike);
            }
        }
        return res;

    }
}