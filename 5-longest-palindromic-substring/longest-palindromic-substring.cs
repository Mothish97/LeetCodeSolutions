public class Solution
{
    public string LongestPalindrome(string s)
    {
        if (s.Length < 2) return s;

        int bestStart = 0, bestLen = 1;

        for (int i = 0; i < s.Length; i++)
        {
            Expand(i, i);       // odd
            Expand(i, i + 1);   // even
        }

        return s.Substring(bestStart, bestLen);

        // local helper captures outer variables
        void Expand(int L, int R)
        {
            while (L >= 0 && R < s.Length && s[L] == s[R])
            {
                L--; R++;
            }
            int len = R - L - 1;           // overshot one step
            if (len > bestLen)
            {
                bestLen = len;
                bestStart = L + 1;
            }
        }
    }
}
