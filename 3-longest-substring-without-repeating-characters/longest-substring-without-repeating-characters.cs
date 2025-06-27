public class Solution {
    public int LengthOfLongestSubstring(string s) 
    {   
        if(s=="") return 0;
        var lst = s.ToList();
        var dct = new Dictionary<char,int>();
        var left = 0;
        var right = 1;
        var res = 1;
        dct.Add(lst[0],0);
        while(right<lst.Count)  
        {
            if(!dct.ContainsKey(lst[right]))
            {            
                res = Math.Max(res,right-left+1);
                dct.Add(lst[right], right); 
                right++;
            }
            else
            {              
               left =  dct[lst[right]]+1;
               right = left+1;           
               dct.Clear();
               dct.Add(lst[left],left);
            }
            
        } 
        return res;
    }

}