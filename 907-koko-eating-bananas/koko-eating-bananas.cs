public class Solution {
    public int MinEatingSpeed(int[] piles, int h) 
    {
        long left = (long)1;
        long right = (long)piles.Max();
        long total =(long) h+1;
        long res =(long) piles.Max();
        while(left<= right)
        {
            long mid = (long) (left+right) / 2; 
            var curAr = piles.Select(x => (x + mid - 1) / mid).ToArray();
            total = (long)curAr.Sum();
            if(total>h)
            {
                left = mid+1;
            }
            else if(total<=h){
                right = mid-1;
                res = mid;
            }
            
        }
        return (int)res;
    }
}