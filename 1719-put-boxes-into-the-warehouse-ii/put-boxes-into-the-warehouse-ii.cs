public class Solution {
    public int MaxBoxesInWarehouse(int[] boxes, int[] war) 
    {
        Array.Sort(boxes);
        Array.Reverse(boxes);
        var box = boxes.ToList();
        var first = 0;
        var last = war.Count()-1;
        var ct = 0;
        Console.WriteLine(string.Join(",",box));
        foreach(var b in box)
        {


            if(war[first]>= b)
            {
                ct++;
                first++;
            }
            else if (war[last]>= b)
            {
                ct++;
                last--;
            }

        }
        if(ct> war.Count()) return war.Count();
        return ct;

        
    }
}