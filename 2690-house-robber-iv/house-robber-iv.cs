public class Solution {
    public int MinCapability(int[] nums, int k)
    {
        int left = nums.Min();
        int right = nums.Max();
        while(left<right)
        {
            int mid = (left+right)/2;
            if(IsValidPick(nums,mid,k))
            {   
                right = mid;
            }
            else{
                left = mid +1;
            }
        }
        return right;

    }

    public bool IsValidPick(int[] nums, int cap,int k)
    {
        int count = 0;
        int i=0;
        while(i< nums.Length)
        {
            if(nums[i]<=cap)
            {
                count++;
                i=i+2;
            }
            else{
                i++;
            }
        }
        return count >=k;
    }

}