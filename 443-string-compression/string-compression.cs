public class Solution {
    public int Compress(char[] chars) 
    {
        if(chars.Count() == 1) return 1;
        var left = 0;
        var right =0;
        var res = chars.Count();
        var ct =0;
        var lst = new List<char>();
        while(right<chars.Count())
        {
            if(chars[left] == chars[right])
            {
                right++;
                ct++;
            }
            else
            {
                lst.Add(chars[left]);
                
                if(ct ==1)
                {
                    left =right;
                    ct=0;
                    continue;
                }
                var ctstr = ct.ToString();
                foreach(char k in ctstr)
                {
                    lst.Add(k);
                }
                left = right;
                ct=0;

            }
            if(right == chars.Count())
            {
                    lst.Add(chars[left]);
                    if(ct ==1) continue;
                    var ctstr = ct.ToString();
                    foreach(char k in ctstr)
                    {
                        lst.Add(k);
                    }
                    left = right;
                    ct=0;
                
            }
            
        }
        for(int i =0; i<lst.Count();i++)
        {
            chars[i] = lst[i];
        }
        return lst.Count();
        
    }
}