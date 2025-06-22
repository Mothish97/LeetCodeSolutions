public class Solution {
    public int[] DailyTemperatures(int[] temp) 
    {
        var warm = new int [temp.Count()];
        var stck = new Stack<(int val,int ind)>();
        for(int i =1; i<temp.Count();i++)
        {
            if(temp[i-1]<temp[i])
            {
                warm[i-1] = 1;
                while(stck.Count>0)
                {
                    var cur = stck.Peek();
                    if(cur.val< temp[i])
                    {
                        warm[cur.ind] = i - cur.ind;
                        stck.Pop();
                    }
                    else
                    {
                        break;
                    }
                }
            }
            else
            {
                stck.Push((temp[i-1],i-1));
            }

        }
        return warm;
    }
}