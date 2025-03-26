public class Solution {
    public int MinimumOperations(int[] nums) 
    {
        var left = 0;
        var right =nums.Length-1;
        var leftVal = nums[0];
        var rightVal = nums[right];
        var result =0;
        while(left<right)
        {
            if(leftVal==rightVal)
            {
                left++;
                right--;
                leftVal = nums[left];
                rightVal = nums[right];
                continue;
            }
            if(leftVal>rightVal)
            {
                right--;
                rightVal = rightVal+nums[right];
            }
            else{
                left++;
                leftVal = leftVal+nums[left];
            }
            result++;
        }
        return result;
        
        
    }
}