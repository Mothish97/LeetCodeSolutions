public class Solution {
    public int[] SearchRange(int[] nums, int target) 
    {
        var left = 0;
        var right = nums.Count()-1;
        var found = -1;
        while(left<=right)
        {
            var mid = (left+right)/2;
            if(nums[mid]>target)
            {
                right = mid-1;
            }
            else if(nums[mid]<target)
            {
                left = mid+1;
            }
            else{
                found = mid;
                break;
            }
        }
        
        if(found == -1) return new int[] {-1,-1};
        left = found; 
        right =found;
        while(right<nums.Count() && (nums[right]== target)  )
        {

            right++;
            
        }
        while(left>-1&& (nums[left]== target)  )
        {

            left--;
            
        }
    

        return new int[] {left+1,right-1};
    }
}