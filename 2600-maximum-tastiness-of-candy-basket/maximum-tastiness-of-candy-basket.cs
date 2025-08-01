public class Solution {
    public int MaximumTastiness(int[] price, int k) 
    {
        Array.Sort(price);
        var left = 0;
        var right = price.Max();
        while(left<= right)
        {
            var mid = left + (right-left)/2;
            if(canpick(mid,k,price))
            {
                left= mid+1;
            }
            else{
                right = mid-1;
            }

        }
    
        return right;
        
    }

    public bool canpick(int diff , int k, int[] price)
    {
        var kused = 1;
        var f = price[0];
        for(int i =1; i< price.Count();i++ )
        {
            if(price[i] - f >=diff)
            {
                f = price[i];
                kused++;
            }
            if(kused>= k)
            {
                return true;
            }
        }
        return false;
    }
}