public class Solution {
    public int Jump(int[] nums) 
    {
        if(nums.Length ==1 ) 
        {
            return 0;    
        }
        var res =0;
        var curPos =0;
        while(curPos<nums.Length-1)
        {   
            var maxStep = 0;
            var maxInd = 0;
            if(curPos + nums[curPos]>=nums.Length-1) 
            {
                Console.WriteLine("Enter Here");
                return res+1;
            }
            for(int j = curPos+1; j<= curPos+nums[curPos];j++)
            {
                if(j>nums.Length -1) break;
                if(j + nums[j] > maxStep)
                {
                    maxStep = j + nums[j];
                    maxInd = j;
                }
            }
            Console.WriteLine($"Max Step : {maxStep}");
            Console.WriteLine($"maxInd : {maxInd}");
            Console.WriteLine($"curPos : {curPos}");
            curPos = maxInd;
            res++;           
        }
        return res;
    }
}