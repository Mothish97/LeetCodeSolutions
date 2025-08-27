public class Solution {
    public int FindMinArrowShots(int[][] points) 
    {
        Array.Sort(points, (a, b) =>
        {
            int cmp = a[0].CompareTo(b[0]);
            if (cmp == 0) // if first values are same, compare second
                return a[1].CompareTo(b[1]);
            return cmp;
        });
        var maxEnd = points[0][1];
        var res = points.Count();
        var visited = new HashSet<int>();

        for(int i =0; i<points.Count();i++)
        {
            if(visited.Contains(i)) continue;
            visited.Add(i);
            var s1 = points[i][0];
            var e1 = points[i][1];
            int j =i+1;
            var maxreach = e1;
            while(j < points.Count())
            {
                if((points[j][0]<= maxreach || points[j][1]<= maxreach) && !visited.Contains(j))
                {
                    maxreach = Math.Min(points[j][1],maxreach);
                    res--;
                    visited.Add(j);
                }
                j++;
            }
            
            
        }
        return res;

    }
}
//[[0,9],[0,6],[2,9],[2,8],[3,9],[3,8],[3,9],[6,8],[7,12],[9,10]]
//[[1,6],[2,8],[7,12],[10,16]]
//[[1,10],[3,9],[4,11],[6,7],[6,9],[8,12],[9,12]]