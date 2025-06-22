public class Solution {
    public int FindMin(int[] nums) 
    {
        var left = 0; 
        var right = nums.Count()-1;
        while(left<= right)
        {
            var mid = (nums[left] + (nums[right] - nums[left]) / 2);
            if(mid> nums[right])
            {
                right--;
            }
            else{
                left++;
            }
        }
        Console.WriteLine(left);
        if(left>0 && left < nums.Count()) return nums[left]; 
        return nums[0]; 
        
    }
}