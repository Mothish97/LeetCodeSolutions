public class Solution {
    public int MaximumBags(int[] capacity, int[] rocks, int add) 
    {
        var remain = new int[rocks.Count()];
        for(int i=0 ; i< remain.Count();i++)
        {
            remain[i] = capacity[i] - rocks[i];
        }
        Array.Sort(remain);
        Console.WriteLine(String.Join(",",remain));
        var res =0;
        for(int i =0;i<remain.Count();i++)
        {
            if(remain[i] == 0)
            {
                res++;
            }
            else if(add>=remain[i])
            {
                res++;
                add = add-remain[i];
            }

        }
        return res;
    }
}