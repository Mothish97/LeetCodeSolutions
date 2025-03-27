public class Solution {
    public int MinOperations(int[][] grid, int x) 
    {
        var flat = new List<int> ();
        foreach(var g in grid)
        {
            flat.AddRange(g.ToList());
        }
        flat.Sort();
        var mid = flat[(flat.Count-1)/2];
        var count =0;
        foreach(var f in flat)//f+ x*count = mid
        {
            var cur = (mid - f)/x;
            var check = f + (x*cur);
            if(check != mid) return -1;
            count = count+ Math.Abs(cur);
        }
        return count;
    }
}