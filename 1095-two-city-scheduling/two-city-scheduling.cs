public class Solution {
    public int TwoCitySchedCost(int[][] costs) 
    {
        Array.Sort(costs, (a, b) => Math.Abs(a[0] - a[1]).CompareTo( Math.Abs(b[0] - b[1])));
        Array.Reverse(costs);
        var sum1 = 0;
        var sum2 =0;
        var res =0;
        foreach (var row in costs)
        {
           if(sum1< costs.Count()/2 && sum2<costs.Count()/2)
           {
                if(row[0]< row[1])
                {
                    res+= row[0];
                    sum1++;
                }
                else
                {
                    res+= row[1];
                    sum2++;
                }
           }
           else if(sum1<  costs.Count()/2 )
           {
                res+= row[0];
                sum1++;            
           }
           else
           {
                res+= row[1];
                sum2++;
           }
        }
        //Console.WriteLine($"Sum1 {sum1}  Sum2 {sum2}");
        return res;
    }
}