public class Solution {
    public int LongestOnes(int[] nums, int k) 
    {
        if(! nums.Contains(1) && k==0) return 0; 
        var kused = 0;
        var stck = new Queue<int>();
        var res =0;
        for(int i =0;i< nums.Count();i++)
        {
            if(nums[i] != 1)
            {
                kused++;
            }
            if(kused > k)
            {
                while(stck.Count>0)
                {
                    var cur = stck.Dequeue();
                    if(cur == 0)
                    {
                        kused--;
                        break;
                    }
                }
               
            }
            stck.Enqueue(nums[i] );
            res = Math.Max(stck.Count(),res);

        }
        return res;
    }
}