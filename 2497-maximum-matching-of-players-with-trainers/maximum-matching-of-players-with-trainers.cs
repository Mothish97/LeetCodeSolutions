public class Solution {
    public int MatchPlayersAndTrainers(int[] pl, int[] tr) 
    {
        var res =0;
        Array.Sort(pl);
        Array.Sort(tr);
        var itr =0;
        var ipl =0;
        while(ipl < pl.Count() && itr<tr.Count())
        {
            if(pl[ipl]<= tr[itr])
            {
                res++;
                ipl++;
                itr++;
            }
            else
            {
                itr++;
            }
            
        }return res;
        
    }
}