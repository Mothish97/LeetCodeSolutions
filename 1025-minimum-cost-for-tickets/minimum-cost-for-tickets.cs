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
            for(int i=0; i<3;i++)
            {
                if(n-pass[i]>=0)
                {
                    min = Math.Min(dp[n-pass[i]] +costs[i], min  );       
                }
                else
                {
                    min = Math.Min(costs[i], min  ); 
                }
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