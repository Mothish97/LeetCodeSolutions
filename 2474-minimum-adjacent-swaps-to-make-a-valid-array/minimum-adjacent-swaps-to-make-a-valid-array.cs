public class Solution {
    public int MinimumSwaps(int[] nums) 
    {
        int max = nums.Max();
        int min = nums.Min();
        var res = 0;
        while(nums[nums.Length-1]!=max)
        {
            var maxLoc = Array.LastIndexOf(nums, max);
            var cur = nums[maxLoc +1];
            nums[maxLoc]= cur;
            nums[maxLoc+1] = max;
            res++;
             //Console.WriteLine(string.Join(", ", nums));
        }
        while(nums[0]!=min)
        {
            var minLoc = Array.IndexOf(nums, min);
            var cur = nums[minLoc -1];
            nums[minLoc]= cur;
            nums[minLoc-1] = min;
            res++;
             //Console.WriteLine(string.Join(", ", nums));
        }
        return res;
    }
}