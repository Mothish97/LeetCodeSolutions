public class Solution {
    public int NumRescueBoats(int[] pep, int limit) 
    {
        Array.Sort(pep);
        var left = 0;
        var right =pep.Count()-1;
        var res = 0;
        var cur =0;
        while(left <=right)
        {
           if(pep[left] + pep[right] <= limit)
           {
                left++;
                right--;
                res++;

           }
           else if(pep[right]<= limit  )
           {
                right--;
                res++;
           }

        }
        return res;



        return res;
        
    }
}

// 1 2 4 5