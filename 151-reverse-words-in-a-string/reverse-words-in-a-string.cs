public class Solution {
    public string ReverseWords(string s) {
        var lst = s.Split(" ");
        var rev  = lst.Reverse();
        var str = new StringBuilder();
        foreach(var wrd in rev)
        {
            if(String.IsNullOrEmpty(wrd)) continue;
            wrd.Trim();
            str.Append(wrd);
            str.Append(" ");
        }
        return str.ToString().Trim();
        
    }
}