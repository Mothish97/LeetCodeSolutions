public class Solution {
    public int MinimizedMaximum(int n, int[] quantities) 
    {
        var left = 0;
        var right = quantities.Max();
        if(n ==1) return right;
        if(quantities.Count() == 1) return right;

        while(left<= right)
        {
            var mid =left +  ((right-left)/2);
            Console.WriteLine($"Mid : {mid}");
            if(mid<1) return 1;
            int totalSubtract = quantities.Sum(x => x > 0 ? (x + mid - 1) / mid : 0);
            //Console.WriteLine(string.Join(",",counts));
            //int totalSubtract = counts.Sum(); 
            //Console.WriteLine($"totalSubtract : {totalSubtract}"); 
            
            if(totalSubtract <=n)
            {
                right= mid-1;
            }
            else if (totalSubtract> n)
            {
                left = mid+1;
            }
        }
        return Math.Max(right,left);
    }
}