public class Solution {
    public long MinSum(int[] nums1, int[] nums2) 
    {
        long sum1 = nums1.Select(x => (long)x).Sum();
        long sum2 = nums2.Select(x => (long)x).Sum();

        if (sum1 > sum2 && !nums2.Contains(0)) return -1;
        if (sum1 < sum2 && !nums1.Contains(0)) return -1;

        long zeros1 = nums1.Count(x => x == 0);
        long zeros2 = nums2.Count(x => x == 0);

        long tsum1 = sum1 + zeros1;
        long tsum2 = sum2 + zeros2;

        if (tsum1 < tsum2)
        {
            long curzero = zeros1;
            long target = tsum2 - sum1;

            foreach (var num in nums1)
            {
                if (num == 0)
                {
                    curzero--;
                    target -= (curzero == 0) ? target : 1;
                }
            }

            return target == 0 ? tsum2 : -1;
        }
        else if (tsum1 > tsum2)
        {
            long curzero = zeros2;
            long target = tsum1 - sum2;

            foreach (var num in nums2)
            {
                if (num == 0)
                {
                    curzero--;
                    target -= (curzero == 0) ? target : 1;
                }
            }

            return target == 0 ? tsum1 : -1;
        }
        else
        {
            return tsum1;
        }
    }
}
