public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) 
    {
        var lst = new List<int>();
        var pq = new PriorityQueue<int,int>();
        foreach(var na in nums1)
        {
            pq.Enqueue(na,na);
        }
        foreach(var na in nums2)
        {
            pq.Enqueue(na,na);
        }
        while(pq.Count>0)
        {
            lst.Add(pq.Dequeue());
        }
        
        int n = lst.Count();

        if (n % 2 == 1)
            return lst[n / 2];
        else
            return (lst[n / 2 - 1] + lst[n / 2]) / 2.0;
    }
}