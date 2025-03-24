public class Solution {
    public int Search(int[] nums, int target)
    {
        if(nums.Length == 0) 
        {
            return -1;
        }
        if(nums.Length == 1)
        {
            if(nums[0]== target) return 0;
            return -1;
        } 
        if(nums.Length == 2)
        {
            if(nums[0]== target) return 0;
            if(nums[1]== target) return 1;
            return -1;
        }

        var left =0;
        var right = nums.Length-1;
        while(left<=right)
        {
          
            int mid =(right + left) /2;
            if(nums[left] == target) return left;
            if(nums[right] == target) return right;
            if(nums[mid] == target) return mid;

            if(nums[left]< nums[mid])
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

            Console.WriteLine($"Mid {mid}");
            Console.WriteLine($"right {right}");
            Console.WriteLine($"left {left}");
             Console.WriteLine($"-------");
        }

        return -1;
    }
}