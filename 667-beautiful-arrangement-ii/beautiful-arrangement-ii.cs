public class Solution {
    public int[] ConstructArray(int n, int k) 
    {
        var res = new int[n];

        // 1) Build the first k+1 numbers: 1, k+1, 2, k, 3, k-1, …
        int left  = 1;       // walk up from 1
        int right = k + 1;   // walk down from k+1
        int idx   = 0;

        while (idx <= k)          // we need exactly k+1 of them
        {
            res[idx++] = left++;  // take from the low end
            if (idx > k) break;   // done?
            res[idx++] = right--; // take from the high end of 1…k+1
        }

        // 2) Append the remaining numbers k+2 … n in order
        for (int num = k + 2; num <= n; num++)
            res[idx++] = num;

        return res;

        
    }
}
// 1 2 3 4 5
// 1 2 4 3  