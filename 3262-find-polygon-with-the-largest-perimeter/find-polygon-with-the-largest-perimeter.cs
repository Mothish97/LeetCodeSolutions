public class Solution {
    public long LargestPerimeter(int[] nums) 
    {
        Array.Sort(nums);
        var pref = new long[nums.Count()];
        pref[0] = nums[0];
        for(int i =1 ; i< nums.Count();i++)
        {
            pref[i] = (long)pref[i-1] + (long)nums[i];
        }   
        long res = 0;

        for(int i =1; i<nums.Count();i++)
        {
            if(nums[i]<pref[i-1])
            {
                res = (long)pref[i];
            }
        }
        if(res ==0) return -1;
        return res;
    }
}
//1 1 2 3 5 12 50
