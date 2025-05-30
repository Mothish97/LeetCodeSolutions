public class Solution {
    public int CalculateTime(string keyboard, string word) 
    {
        var dct = new Dictionary<char,int>();
        for(int i=0; i < keyboard.Count();i++)
        {
            dct.Add(keyboard[i],i);
        }
        var result = 0;
        var cur =0;
        for(int i =0;i< word.Count();i++)
        {
            var loc = dct[word[i]];
            result += Math.Abs(loc - cur);
            cur = loc;
        }
        return result;
        
    }
}