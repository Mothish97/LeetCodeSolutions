public class Solution {
    public bool CanJump(int[] nums)
    {
        if(nums.Count() <=1 ) return true;
        var ind =0;

        while(ind < nums.Count()-1)
        {
            var add = 0;
            var max = 0;
            if(nums[ind] == 0) return false;
            for(int i = 1 ; i<= nums[ind]; i++)
            {
                if(ind+i >= nums.Count()) return true;
                if(max< ind + i + nums[ind+i])
                {
                    add = i;
                    max = ind + i + nums[ind+i];
                }
            }
            //Console.WriteLine($"ind {ind} +  add{add}  =  {ind+add}" );
            ind+= add;
        }
        return true;
    }
}