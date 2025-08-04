public class Solution {
    public int MinimumSwap(string s1, string s2) {
        if (s1.Length != s2.Length) return -1;

        int xy = 0, yx = 0;

        for (int i = 0; i < s1.Length; i++) {
            if (s1[i] == 'x' && s2[i] == 'y') xy++;
            else if (s1[i] == 'y' && s2[i] == 'x') yx++;
        }

        int totalMismatch = xy + yx;
        if (totalMismatch % 2 != 0) return -1;

        // Every two xy → 1 swap, every two yx → 1 swap
        // One leftover xy and yx → 2 swaps
        return (xy / 2) + (yx / 2) + 2 * (xy % 2);
    }
}
