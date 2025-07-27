public class Solution {
    public int ShipWithinDays(int[] weights, int days) 
    {
        var left = weights.Max();
        var right = weights.Sum();
        var res = weights.Sum();
        while(left<=right)
        {
            var mid = left + (right - left) / 2; 
            //Console.WriteLine(mid);
            if(possible(mid,weights,days))
            {
                right = mid-1;
                //res = Math.Min(res,mid);
            }
            else{
                left = mid+1;
            }
        }
        return left;
        //Console.WriteLine(possible(5,weights,days));
        //return 0;
        
    }

    public bool possible(int value, int[] w,int days)
    {
        var right =0;
        var curTotal =0;
        var daysTaken = 0;
        while(right<w.Length)
        {
            if(daysTaken ==  days ) return false;
            curTotal = curTotal + w[right];
            
            if(curTotal > value)
            {
               // Console.WriteLine(curTotal- w[right] );
                daysTaken++;
                //Console.WriteLine($"Day : {daysTaken}");

                if(daysTaken> days)
                {
                    return false;
                }
                curTotal = 0;
                continue;
            }
            right++;
            if(daysTaken> days)
            {
                return false;
            }
            
        }
        return true;
    }
}