public class Solution {
    public int MinProcessingTime(IList<int> processorTime, IList<int> tasks) {
        //1 2 2 3
        var tsk = tasks.ToList();
        tsk.Sort();
        var prt = processorTime.ToList();
        prt.Sort();
        tsk.Reverse();
        var swap = 0;
        var ind = 0;
        var res = 0;
        for(int i =0; i< tsk.Count && ind<prt.Count();i++)
        {
            swap++;
            Console.WriteLine($"{prt[ind]} + {tsk[i]} =  {prt[ind] + tsk[i]}");
            res = Math.Max(res,prt[ind] + tsk[i]);
            if(swap == 4 )
            {
                ind++;
                swap= 0;
            }

        }
        Console.WriteLine(string.Join(",",tsk));
        return res;
    }
}