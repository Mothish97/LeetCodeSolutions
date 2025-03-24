public class Solution {
    public int SubarraySum(int[] nums, int k) 
    {
        int cur =0;
        var left =0;
        var count =0;
        while(left<nums.Length)
        {
            for(int i=left; i<nums.Length;i++)
            {
                
                cur = cur + nums[i];
               // Console.WriteLine($"bef loop cur  {cur}");
                //Console.WriteLine($"bef loop k {k}");
                if(cur == k) 
                {
                    //Console.WriteLine($"cur {cur}");
                    //Console.WriteLine($"k {k}");
                    count++;
                }
                //if(cur> k) break;
            }
            Console.WriteLine($"Out For loop");

            left++;
            cur =0;
        }
        return count;
        
    }
}