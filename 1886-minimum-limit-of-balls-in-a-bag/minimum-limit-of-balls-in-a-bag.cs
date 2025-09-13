public class Solution {
    public int MinimumSize(int[] nums, int maxOperations) 
    {
        Array.Sort(nums);
        var left =1;
        var right = nums.Max();
        while(left <= right)
        {
            var mid = left + (right -left)/2;
            if(IsPossible(nums,mid,maxOperations))
            {
                right = mid -1;
            }
            else
            {
                left = mid+1;
            }
        }
        return left;
    }
    public bool IsPossible(int [] nums, int mid, int mx)
    {
        var cur = 0;
        foreach(var n in nums)
        {
            var val = n;
            if(val <= mid) continue;
            cur += (int)Math.Ceiling((double)val / mid) - 1;
            //cur--;
            if(cur> mx) return false;
            
        }
        return true;
    }
}