public class Solution {
    public int Search(int[] nums, int target) 
    {
        var left = 0;
        var right = nums.Count()-1;
        

        while(left<= right)
        {
            var mid = left + (right - left)/2;

            if(target == nums[mid])
            {
                return mid;
            }
            if(target == nums[left])
            {
                return left;
            }
                if(target == nums[right])
            {
                return right;
            }
            if(nums[left] < nums[mid])
            {
                if(target >= nums[left] && target <nums[mid])
                {
                    right = mid -1;
                }
                else 
                {
                    left = mid+1;
                }
            }
            else{
                if(target <= nums[right] && target >nums[mid])
                {
                    left = mid +1;
                }
                else 
                {
                    right = mid-1;
                }
            }


        }
        return -1;
        
    }
}