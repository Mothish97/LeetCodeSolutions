public class Solution {
    public bool MergeTriplets(int[][] triplets, int[] target) 
    {
        var f1=false;
        var f2 = false;
        var f3 = false;
        foreach(var d in triplets)
        {
            var t1 = target[0];
            var t2 = target[1];
            var t3 = target[2];
            var d1 = d[0];
            var d2 = d[1];
            var d3 = d[2];
            if(d1 == t1 && !f1)
            {
                if(d2<= t2 && d3<=t3)
                {
                    f1=true;
                }
            }

            if(d2 == t2 && !f2)
            {
                if(d3<= t3 && d1<=t1)
                {
                    f2=true;
                }
            }


            if(d3 == t3 && !f3)
            {
                if(d2<= t2 && d1<=t1)
                {
                    f3=true;
                }
            }

        }
        if(f1 && f2 && f3) return true;
        return false;
    }
}