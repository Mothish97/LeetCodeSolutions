public class Solution {
    private  readonly Dictionary<char, string> dct = new Dictionary<char, string>
    {
        { '2', "abc" },
        { '3', "def" },
        { '4', "ghi" },
        { '5', "jkl" },
        { '6', "mno" },
        { '7', "pqrs" },
        { '8', "tuv" },
        { '9', "wxyz" }};

    public void dfs(string digits,string curString, List<string> output,int curLvl)
    {
        if(curString.Length ==digits.Length)
        {   
            output.Add(curString);
            return;
        }
        var dig = dct[digits[curLvl]];
        foreach(var c in dig)
        {
            dfs(digits,curString+c.ToString(),output,curLvl+1);
        }
    }
    public IList<string> LetterCombinations(string digits)
    {
        var output = new List<string>();
        if(digits == "") return output;
        dfs(digits,"",output,0);
        return output;
    }
}