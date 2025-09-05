public class Solution {
    public void SortColors(int[] nums) {
        var left = 0;
        var right = 0;
        while(left <nums.Count() && right <nums.Count())
        {
            if(nums[right]< nums[left])
            {
                var cur= nums[left];
                nums[left] = nums[right];
                nums[right] = cur;
                left =0; right=0;
            }
            else{
                right++;
            }
            if(right >= nums.Count())
            {
                left ++;
                right = left;
            }


        }
    }
}