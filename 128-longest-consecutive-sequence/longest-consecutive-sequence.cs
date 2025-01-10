public class Solution {
    public int LongestConsecutive(int[] nums) 
    {
        if (nums.Length == 0) return 0;

        var numSet = new HashSet<int>(nums);
        var maxSum = 1;
        
        foreach(var n in numSet)
        {
            if(!numSet.Contains(n-1))
            {
                var curNum = n;
                var curSeq = 1;
                while(numSet.Contains(curNum+1))
                {
                    curSeq++;
                    curNum++;
                }
                maxSum = Math.Max(curSeq,maxSum);

            }
        }
        return maxSum;

    }
}