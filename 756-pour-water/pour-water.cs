public class Solution {

    public void fillWater(int k , int [] heights)
    {
        var min= k;
        for(int i = k; i>=0;i--)
        {
            if(heights[i]<heights[min])
            {
                min = i;
            }
            if(heights[i]> heights[k])
            {
                break;
            }
            if(heights[min]<heights[i])
            {
                break;
            }
        }
        if(min!= k)
        {
            heights[min]++;
            return;
        }
        for(int i =k; i< heights.Length;i++)
        {
            if(heights[i]<heights[min])
            {
                min = i;
            }
            if(heights[i]> heights[k])
            {
                break;
            }
            if(heights[min]<heights[i])
            {
                break;
            }
        }
        heights[min]++;
    }
    public int[] PourWater(int[] heights, int volume, int k)
    {
        var cur  = 0;
        //Console.WriteLine(string.Join(" ", heights));
        while(cur<volume)
        {
            fillWater( k , heights);
            cur++;
            //Console.WriteLine(string.Join(" ", heights));
        }
        return heights;
        
    }
}