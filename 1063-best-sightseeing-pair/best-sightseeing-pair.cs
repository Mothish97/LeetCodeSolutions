public class Solution {
    public int MaxScoreSightseeingPair(int[] val)
    {
        int n = val.Length;
        int best = val[0] + 0;   // best val[j] + j so far
        int ans  = int.MinValue;

        for (int i = 1; i < n; i++) {
            ans = Math.Max(ans, best + val[i] - i);
            best = Math.Max(best, val[i] + i);
        }
        return ans;
    }
}
//[ 8 1 5 2 6]
//[ 0 0 0 0 0 0]
//[ 8 8 11   ]