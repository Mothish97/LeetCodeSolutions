public class Solution {
    public int LengthOfLastWord(string s) {
        string trimmed = s.Trim();
        List<string> result = trimmed.Split().ToList();
        var str  = result[^1];
        return str.Length;
        
    }
}