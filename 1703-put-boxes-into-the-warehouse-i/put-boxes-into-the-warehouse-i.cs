public class Solution {
    public int MaxBoxesInWarehouse(int[] box, int[] war) 
    {
        Array.Sort(box);
        var pre = new int[war.Count()];
        var minSoFar = int.MaxValue;
        for(int i =0; i<war.Count();i++)
        {
            minSoFar = Math.Min(minSoFar,war[i]);
            pre[i] = minSoFar;
        }

        int b =0;
        for(int i = war.Count()-1; i>=0 && b < box.Count();i--)
        {
            if(pre[i]>= box[b])
            {
                b++;
            }
        }
        return b;
            
        
    }
}