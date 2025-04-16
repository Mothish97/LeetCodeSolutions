public class Solution {
    public int CanCompleteCircuit(int[] gas, int[] cost) 
    {
        var total = 0;
        var cur = 0;
        var start = 0;
        for(int i = 0;i< gas.Length;i++)
        {
            total += gas[i] - cost[i];
            cur += gas[i] - cost[i];
            if(cur< 0)
            {
                start = i+1;
                cur=0;
            }

        }

        if(total < 0) return -1;
        return start;

        
    }
}