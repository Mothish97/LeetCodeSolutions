public class Solution {
    public int[] FindBuildings(int[] hgt) 
    {
       var stck = new Stack<(int val,int ind)>();
       stck.Push((hgt[hgt.Count() -1 ], hgt.Count() -1 ));
       
       for(int i =hgt.Count() -1 ;i>=0;i--)
       {
            if(stck.Peek().val< hgt[i])
            {
                stck.Push((hgt[i],i));
            }
       }
       var res = new int[stck.Count()];
       var ind = 0;
    
       while(stck.Count()>0)
       {
            res[ind] = stck.Pop().ind;
            ind++;
       }
       //Array.Reverse(res);
       return res;
    }
}