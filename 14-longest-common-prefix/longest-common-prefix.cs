public class Solution {
    public string LongestCommonPrefix(string[] strs) 
    { 
        Array.Sort(strs, (x, y) => x.Length.CompareTo(y.Length)); 
        var c = strs[0];
        for(int i=0; i< strs.Length;i++)
        {
            if(strs[i].StartsWith(c))
            {
                continue;
            }
            c=c.Remove(c.Length - 1) ;
            i--;
        }
        return c;
    }
}