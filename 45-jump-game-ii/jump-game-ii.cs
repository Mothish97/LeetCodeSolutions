public class Solution {
    public int Jump(int[] nums) 
    {
        //2 3 1 1 4
        if(nums.Count() <=1) return 0;
        if(nums[0] >= nums.Count()-1) return 1;

        var ind =0;
        var res =1;
        while( ind < nums.Count())
        {
            var maxStep  = 0;              
            var add = 0;
            for(int i=1 ;i<=nums[ind];i++)
            {  
                if(ind+i >= nums.Count()) return res;
                if(maxStep <=nums[ind+i] + i+ ind)
                {
                    maxStep =nums[ind+i] + i+ ind;
                    add=i;
                }
            } 
            Console.WriteLine($"add: {add}, ind :{ind}");
            ind += add;
            if(ind >= nums.Count()-1 ) return res;
            if(ind + nums[ind] >= nums.Count()-1) return res+1;
            res++;
            
            
        }
        return res;
    }
}

// 

                // if(i+ ind + nums[ind+i]>= nums.Count()-1 )
                // {
                //     Console.WriteLine($"Return here {ind} + {nums[ind]} + {i}");
                //     return res+1;
                // }