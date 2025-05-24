public class Solution {
    public bool CanAttendMeetings(int[][] intervals)
    {
        Array.Sort(intervals, (a, b) => a[0].CompareTo(b[0]));
        for(int i =0 ; i < intervals.Length-1;i++)
        {
            if(intervals[i][1]> intervals[i+1][0])
            {
                return false;
            }
        }
        return true;
    }
}