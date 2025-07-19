public class Solution {
    public int CanCompleteCircuit(int[] gas, int[] cost) 
    {
        if(cost.Sum()> gas.Sum()) return -1;
        var prGas =0;
        var prCo =0;
        var spent = new List<int>();
        var res = 0;
        for(int i = 0; i< gas.Count();i++)
        {
            
            prGas = gas[i] - cost[i];
            spent.Add(prGas);
            prCo += prGas;
            
            if(prCo<0)
            {
                prCo = 0;
                res = i+1;
            }
        }


        return res;
        
    }
}