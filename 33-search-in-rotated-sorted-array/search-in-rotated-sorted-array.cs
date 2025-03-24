public class Solution {
    public int Search(int[] nums, int target)
    {
        if(nums.Length == 0) 
        {
            return -1;
        }

        var left =0;
        var right = nums.Length-1;
        while(left<=right)
        {
          
            int mid =(right + left) /2;

            if(nums[mid] == target) return mid;

            if(nums[left]<= nums[mid])
            {  
                if (target < nums[mid] && target>= nums[left])
                {
                    right = mid-1;
                }
                else{
                    left = mid+1;
                }
            }            
            else 
            {
                if(target > nums[mid] && target<= nums[right])
                {
                    left = mid+1;
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