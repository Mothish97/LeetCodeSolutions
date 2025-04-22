public class Solution {

    public void dp(int cur , Dictionary<int,int> dct, int[] nums)
    {
        if(cur == -1)
        {
            dct.Add(-1,0);
            return ;
        }

        dp(cur-1,dct,nums);
        var res = dct[-1];
        for(int i =0; i< cur;i++)
        {
            if(nums[i]< nums[cur])
            {
                res = Math.Max(res,dct[i]);
            }
        }
        dct.Add(cur,res+1);
    }

    public int LengthOfLIS(int[] nums)
    {
        var dct = new Dictionary<int,int>();
        dp(nums.Length-1,dct,nums);
        var max = 0;
        foreach(var d in dct)
        {
            max = Math.Max(d.Value,max);
            //Console.WriteLine($"{d.Key}  {d.Value}");
        }
        return max;
    }
}