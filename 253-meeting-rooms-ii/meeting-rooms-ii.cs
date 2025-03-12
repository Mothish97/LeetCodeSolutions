public class Solution {
    public int MinMeetingRooms(int[][] intervals) {
        Array.Sort(intervals,(a,b)=> 
        a[0]== b[0] ? a[1].CompareTo(b[1]) :a[0].CompareTo(b[0]));
        var pq = new PriorityQueue<int,int>();
        var room = pq.Count;
        foreach(var itr in intervals)
        {
            if(pq.Count ==0)
            {
                pq.Enqueue(itr[1],itr[1]);
            }
            else
            {
                var minR=  pq.Dequeue();
                if(minR > itr[0])
                {
                    pq.Enqueue(minR,minR);
                }
       
                pq.Enqueue(itr[1],itr[1]);
            }

            room = Math.Max(room,pq.Count);
        }


        return pq.Count;
    }
}