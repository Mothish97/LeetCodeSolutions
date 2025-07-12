public class Solution {
    public int MaxBoxesInWarehouse(int[] boxes, int[] war) 
    {
        Array.Sort(boxes);
        Array.Reverse(boxes);
        var box = boxes.ToList();
        var mins = new int[war.Count()];
        mins[0] = war[0];
        for(int i =1; i<war.Count();i++)
        {
            mins[i] = Math.Min(war[i], mins[i-1]);
        }
        var count =0;
        // Console.WriteLine(string.Join(",",mins));
        // Console.WriteLine(string.Join(",",box));

        for(int i =0 ; i < mins.Count() ; i++)
        {
            while(box.Count>0)
            {     
                var last = box[0];
                box.RemoveAt(0);
                if(mins[i] >= last)
                {
                    count++;
                    break;
                }     
            }
        }
        return count;
        
    }
}