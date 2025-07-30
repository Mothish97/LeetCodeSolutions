public class Solution {
    public int MaximumGroups(int[] grades) {
        Array.Sort(grades);
        Console.WriteLine(string.Join(",",grades));
        var lstsum = 0;
        var lastgrp = 0;
        var curgrp = 0;
        var i =0;
        var cursum =0;
        var res = 0;
        while(i< grades.Count() )
        {  
            while( (curgrp<= lastgrp || cursum <=lstsum))
            {
                cursum += grades[i];
                curgrp++;
                i++;
                if(curgrp > lastgrp && cursum > lstsum) break;
                if(i >= grades.Count()) return res;
            }
            Console.WriteLine($"cursum {cursum}  curgrp {curgrp}");
            lstsum = cursum;
            lastgrp++;
            cursum = 0;
            curgrp = 0;
            res++;
        }
        return res;
    }
}