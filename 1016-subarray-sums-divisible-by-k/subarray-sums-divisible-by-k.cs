public class Solution {
    public int SubarraysDivByK(int[] nums, int k) {
        var result = 0;
        var cur = 0;
        var dct = new Dictionary<int,int>();
         dct.Add(0,1);
        for(int i =0; i< nums.Length;i++)
        {
            cur += nums[i];
            var mod = (cur % k + k)  % k;
            Console.WriteLine(mod);
            if(dct.ContainsKey(mod))
            {
                result+= dct[mod];
                dct[mod]++;         
            }
            else
            {
                dct.Add(mod,1);
            }
            
        }


        
        return result; 
    }
}