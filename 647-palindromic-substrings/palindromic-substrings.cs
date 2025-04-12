public class Solution {

    public void expand(string s ,int left ,int right, List<string> seen)
    {
        while(left>=0 && right < s.Length && s[left] == s[right])
        {
            string substring = s.Substring(left, right - left + 1);
            
            seen.Add(substring);
            
            left--;
            right++;
        }
    }
    public int CountSubstrings(string s)
     {
        var seen = new List<string>();

        for (int i = 0; i < s.Length; i++)
        {
            expand(s, i, i, seen);     // Odd-length palindromes
            expand(s, i, i + 1, seen); // Even-length palindromes
        }
        //if(seen == null) return 0;
        return seen.Count;
    }
}