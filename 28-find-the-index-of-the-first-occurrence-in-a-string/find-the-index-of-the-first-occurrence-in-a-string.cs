public class Solution {
    public int StrStr(string haystack, string needle) {
        var left=0;
        var right = needle.Length;
        while(left+right<=haystack.Length)
        {
            if(haystack.Substring(left,right) == needle)
            {
                return left;
            }
            left++;
        }
        return -1;
    }
}