public class Solution {
    public string RemoveDuplicates(string s, int k) 
    {
        var stck = new Stack<char>();
        var lst = s.ToCharArray().ToList();
        // Console.WriteLine(s);
        for(int i =0; i<lst.Count;i++ )
        {
            //Console.WriteLine("loop :" + i.ToString());
            if(stck.Count == 0)
            {   
                stck.Push(lst[i]);
                continue;
            }
            if(stck.Peek() == lst[i])
            {
                stck.Push(lst[i]);
                if(stck.Count ==k)
                {   
                    lst.RemoveRange(i-k+1, k);
                    i=-1;
                    stck.Clear();
                    //Console.WriteLine(string.Join("", lst));
                } 
                
            }
            else
            {
                stck.Clear();
                stck.Push(lst[i]);
            }
            
    
        }
        return new string(lst.ToArray());
        
    }
}