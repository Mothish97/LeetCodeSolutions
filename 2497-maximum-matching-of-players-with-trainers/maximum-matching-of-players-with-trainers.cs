public class Solution {
    public int MatchPlayersAndTrainers(int[] players, int[] trainers) 
    {
        var res =0;
        Array.Sort(players);
        Array.Sort(trainers);
        var pl = players.ToList();
        var tr = trainers.ToList();
        var ipl = 0;
        var itr = 0;
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