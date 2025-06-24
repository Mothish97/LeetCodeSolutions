public class Solution {
    public string RobotWithString(string s) 
    {
        var stck = new Stack<char>();
        var dct = new Dictionary<char,int>();
        var ar = s.ToCharArray();
        for(int i = 0; i<ar.Count();i++)
        {
            if(dct.ContainsKey(ar[i]))
            {
                dct[ar[i]]++;
            }
            else{
                dct.Add(ar[i],1);
            }
        }
        
        var res = new StringBuilder();
        var curMin = dct.Keys.Min();

        for(int ind =0 ;  ind< ar.Count();ind++)
        {   
            
            if(ar[ind] == curMin)
            {
                res.Append(ar[ind]);
            }
            else
            {
                stck.Push(ar[ind]);
            }
            dct[ar[ind]]--;
            if(dct[ar[ind]]==0)
            {
                dct.Remove(ar[ind]);
            }
            if(dct.Count>0)
            {
                curMin = dct.Keys.Min();
                while(stck.Count > 0 &&  stck.Peek()<= curMin)
                {
                    res.Append( stck.Pop());
                }
            }
        }

        
        while(stck.Count>0)
        {
            res.Append( stck.Pop());
        }
        return res.ToString();
        
    }
}