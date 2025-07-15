public class Solution {
    public int MinProductSum(int[] nums1, int[] nums2) 
    {
        var res =0;
        Array.Sort(nums1);
        Array.Sort(nums2);
        Array.Reverse(nums1);
        for(int i =0; i<nums1.Count();i++)
        {
            res+= nums1[i]*nums2[i];
        }
        return res;
    }
}