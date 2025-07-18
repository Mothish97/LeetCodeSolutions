public class Solution {
    public int MaxSubArray(int[] nums) {
        var max =nums[0];
        var res = nums[0];
        var prefSum = nums[0];
        for(int i =1 ; i< nums.Count(); i++)
        {
            if(prefSum+ nums[i]>= nums[i])
            {
                prefSum += nums[i];
            } 
            else{
                prefSum =nums[i];
            }
            max = Math.Max(prefSum,max);
            //Console.WriteLine(prefSum);
        }
        return max;
        
    }
}