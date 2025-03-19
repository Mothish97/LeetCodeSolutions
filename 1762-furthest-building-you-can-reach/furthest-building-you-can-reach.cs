public class Solution {
    public int FurthestBuilding(int[] heights, int bricks, int ladders) 
    {
        var pq = new PriorityQueue<int, int>(Comparer<int>.Create((a, b) => b - a));
        for(int i=0;i<heights.Length-1;i++)
        {
            if(heights[i]< heights[i+1])
            {
                var diff =  heights[i+1] - heights[i];
                pq.Enqueue(diff,diff);
                var availableBricks = bricks -diff;
                //Console.WriteLine($"Available bricks : {availableBricks}");
                if(availableBricks<0)
                {
                    if(ladders>0)
                    {
                        var curHi = pq.Dequeue();
                        ladders--;
                        bricks = bricks + curHi - diff;
                    }
                    else{
                        return i;
                    }
                }else
                {
                    bricks = availableBricks;
                }
            }
        }
        return heights.Length-1;
        
    }
}