public class Solution {
    public int LongestConsecutive(int[] nums) 
    {
        if(nums.Length ==0) return 0;
        var sortedSet = new SortedSet<int>();
        foreach(var n in nums)
        {
            sortedSet.Add(n);
        }
        var maxCt =1;
        var ct = 1;
        var sortList = sortedSet.ToList();
        for(int i=0;i<sortList.Count-1;i++)
        {
            var diff = sortList[i+1] - sortList[i];
            if(diff==1 )
            {
                ct++;
            }
            else{
                ct=1;
            }
            maxCt = Math.Max(ct,maxCt);
        }
        return maxCt;
    }
}