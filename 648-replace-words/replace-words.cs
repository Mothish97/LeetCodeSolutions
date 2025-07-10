public class Solution {
    public string ReplaceWords(IList<string> dictionary, string sentence) 
    {
        var res = new StringBuilder();
        var hsh = new HashSet<string>();
        var max = 0;
        foreach(var d in dictionary)
        {
            hsh.Add(d);
            max = Math.Max(d.Count(),max);
        }
        foreach(var word in sentence.Split(" "))
        {
            var cur = "";
            var found = false;
            for(int i =0;i<word.Count() && i < max;i++)
            {   
                cur+= word[i].ToString();
                if(hsh.Contains(cur))
                {
                    res.Append(cur);
                    found = true;
                    break;
                }
            }
            if(!found)
            {
                res.Append(word);
            }
            res.Append(" ");
        }
        return res.ToString().Trim();
    }
}