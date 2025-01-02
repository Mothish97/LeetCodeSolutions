public class Solution {
    public int RemoveDuplicates(int[] nums) 
    {
        var left =0;
        var right =1;
        if(nums.Length<=2) return nums.Length;
        while(right< nums.Length)
        {
            
            
            if(nums[left] != nums[right])
            { 
                var cur = right- left;
                if(cur>2)
                {
                    var shift = cur-2;
                    for(int i = right; i<nums.Length;i++)
                    {
                        nums[i-shift]= nums[i];                       
                    }
                    for(int i =0;i<shift;i++)
                    {
                        nums[nums.Length-shift] = int.MinValue;
                    }

                    left = right-shift;
                    right = left;
                }
                else{
                    left = right;
                } 
                
            }
            right++;
        }
 
        int index = Array.IndexOf(nums, int.MinValue);
        if(index==-1 && right-left>2) 
        {
            var shift = right - left;
            return nums.Length - (shift-2);
        }
        if(index==-1)
        {
             return nums.Length;
        }
        

        return index;
    }
}