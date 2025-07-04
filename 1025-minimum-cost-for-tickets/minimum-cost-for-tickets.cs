public class Solution {
    public int MincostTickets(int[] days, int[] costs)
    {
     //[0,1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16]  
     //[0,2,2,2,4,4,6,7,9,0,0, 0, 0, 0, 0, 0,0,0] 
//                  (8vs7)

    var dp = new int[days[days.Count()-1]+1];
    var pass = new int[3]{1,7,30};
    var didx = 0;

    for(int n =1; n<dp.Count(); n++)
    {
        
        if(days[didx]== n)
        {
            Console.WriteLine(days[didx]);
            var min = int.MaxValue;
            if(n-1>=0)
            {
                min = Math.Min(dp[n-1] +costs[0], min  );       
            }
            else
            {
                min = Math.Min(costs[0], min  ); 
            }
            if(n-7>=0)
            {
                min = Math.Min(dp[n-7] +costs[1], min  );       
            }
            else
            {
                min = Math.Min(costs[1], min  ); 
            }
            if(n-30>=0)
            {
                min = Math.Min(dp[n-30] +costs[2], min  );       
            }
            else
            {
                min = Math.Min(costs[2], min  ); 
            }

            didx++;
            dp[n] = min;
            //Console.WriteLine($"day{n} with {min}");
        }
        else
        {   
            dp[n] = dp[n-1];
        }


       
    }
   // Console.WriteLine(string.Join(",",dp));      


     return dp[dp.Count()-1];
     
    }
}