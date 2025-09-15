public class Solution {
    public int[] PourWater(int[] heights, int volume, int k) 
    {
        var v =0;
        var cur =k; 
        while(v< volume)
        {
            var idx =k;
            var min = heights[k];
            cur=k;
            while(cur>=0 )
            {
                if(min > heights[cur])
                {
                    min =  heights[cur];
                    idx = cur;
                }
                else if(heights[cur]> min)
                {
                    break;
                }
                cur--;
            }
            if(idx ==k)
            {
                cur =k;
                while(cur<heights.Count())
                {
                    if(min > heights[cur])
                    {
                        min =  heights[cur];
                        idx = cur;
                    }
                    else if(heights[cur]> min)
                    {
                        break;
                    }
                    cur++;
                }
            }

            heights[idx] = heights[idx] +1;
            v++;
        }
        return heights;
    }
}