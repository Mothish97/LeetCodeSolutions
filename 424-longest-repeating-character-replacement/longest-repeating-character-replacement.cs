public class Solution {
    public int CharacterReplacement(string s, int k) 
    {
        var left =0;
        var right = 1;
        var ar = s.ToCharArray(); 
        if(ar.Count()==0) return 0;
        if(ar.Count()==1) return 1;
        var res = 0;
        var dct = new Dictionary<char,int>();
        var max = 1;
        dct.Add(ar[left],1);
        while(right < ar.Count())
        {   
            if(dct.ContainsKey(ar[right]))
            {
                dct[ar[right]]++;
            }
            else
            {
                dct.Add(ar[right],1);
            }
            max =dct.Values.Max();
            var used = dct.Values.Sum() - max;
            if(k==0)
            {
                res = Math.Max(max,res);
            }
            if(used>k)
            {
                dct[ar[left]]--;
                if(dct[ar[left]]==0)
                {
                    dct.Remove(ar[left]);
                }
                left++;
            }
            else{
                res = Math.Max(res,right-left+1);
            }
            
            right++;  
        }
        
        return res;
    }
}