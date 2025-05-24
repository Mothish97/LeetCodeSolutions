public class Solution {
    public int LengthOfLongestSubstringTwoDistinct(string s) 
    {
        var uniq = new Dictionary<char,int>();
        var left = 0;
        var right =0;
        var res = 0;
        while(right<s.Length && left<s.Length )
        {
            // Console.WriteLine(string.Join(", ", uniq.Select(kv => $"{kv.Key}:{kv.Value}")));
            // Console.WriteLine($"left : {left}  Right : {right}");
            if(uniq.Count>2)
            {
                uniq[s[left]]--;
                if(uniq[s[left]] <=0)
                {
                    uniq.Remove(s[left]);
                }
                left++;
                continue;
            }
            if(uniq.ContainsKey(s[right]))
            {
                uniq[s[right]]++;
            }
            else
            {
                uniq.Add(s[right],1);
            }
            if(uniq.Count <3)
            {
                res = Math.Max(right-left+1,res);
            }
            
            right++;   
                  
        }
        return res;

    }
}