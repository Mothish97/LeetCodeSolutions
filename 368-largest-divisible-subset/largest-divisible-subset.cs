public class Solution {
    public IList<int> LargestDivisibleSubset(int[] nums) {
        Array.Sort(nums);
        if(nums.Count()==1) return nums.ToList();
        var dp = new int[nums.Count()];
        var prev = new int[nums.Count()];
        Array.Fill(prev, -1);
        var bestval = 0;
        var bestind = 0;
        for(int i =0; i< nums.Count();i++)
        {
            for(int j =0; j<i;j++)
            {
                if(nums[i] % nums[j]==0)
                {
                    if(dp[i] < dp[j]+1)
                    {
                        prev[i] = j;
                        dp[i] = dp[j]+1;
                    }
                    if(dp[i]> bestval)
                    {
                        bestind = i;
                        bestval = dp[i];
                    }
                }
            }
        }

        var res = new List<int>();
        Console.WriteLine(string.Join(",",dp));
        Console.WriteLine(string.Join(",",prev));
        

        while(bestind > 0)
        {
            Console.WriteLine(bestind);
            res.Add(nums[bestind]);
            bestind = prev[bestind];
            if(bestind ==0)
            {
                res.Add(nums[0]);
                break;
            }
        }
        if(res.Count() == 0)
        {
            res.Add(nums[0]);
            return res;
        }
        return res;     
    }
}