public class Solution {
    public int MissingElement(int[] nums, int k) 
    {
        var count = nums.Count()-1;
        var missed = nums[count] - nums[0] - count;
        if(missed<k)
        {        
            return nums[count]  + (k - missed);
        }

        int getmiss( int n )
        {
            return nums[n] -  nums[0] - n;
        }

        var left = 0;
        var right = count;
        var miss =0;
        var mid =0;
        while(left < right)
        {
            mid = left + (right-left)/2;
            miss  = getmiss( mid);

            Console.WriteLine($"left {left}  right {right} mid{mid}  miss {miss}");
            // Console.WriteLine($"num[left] {nums[left]}  mid {nums[mid]} mid{mid}  miss {miss}");
            if(miss >k)
            {
                right = mid;
            }
            else if(miss<k){
                left = mid+1;
            }
            else{
                right = mid;
            }
        }
        Console.WriteLine($"left {left}  right {right} mid{mid}  miss {miss}");

        missed = nums[right] - nums[left -1] -(right -left+1);
        Console.WriteLine($"num[left] {nums[left-1]}  right {nums[right]} missed {missed} ");

        missed  = getmiss( left -1);
        return nums[left -1] +k - missed  ;

    }
}