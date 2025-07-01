public class Solution {
    public int MaxBoxesInWarehouse(int[] boxes, int[] warehouse)
    {
        var count =0;
        Array.Sort(boxes);
        Array.Reverse(boxes);
        var war =warehouse.ToList();
        for(int i =0;i<boxes.Count()&& war.Count >0;i++)
        {

            if(war[0]>= boxes[i])
            {
                count++;
                war.RemoveAt(0);
            }
            else if(war[war.Count-1]>=boxes[i])
            {
                count++;
                war.RemoveAt(war.Count-1);
            }
        }
        return count;
        
    }
}