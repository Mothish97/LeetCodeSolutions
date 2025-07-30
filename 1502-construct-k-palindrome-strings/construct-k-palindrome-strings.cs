public class Solution {
    public bool CanConstruct(string s, int k) 
    {
        if (k > s.Length) return false;
        if (k == s.Length) return true;

        var freq = new int[26];
        foreach (var c in s)
            freq[c - 'a']++;

        int oddCount = 0;
        foreach (var f in freq)
            if ((f & 1) != 0) oddCount++;

        return oddCount <= k;
    }
}
