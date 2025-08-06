public class Solution {
    public long MinimumSteps(string s)
    {
        var arr = s.ToCharArray();

        var left = 0;
        var right = 1;
        long res =0;
        while(right < arr.Count())
        {
            if(arr[left] =='1' && arr[right] =='0')
            {
                arr[left]= '0';
                arr[right] = '1';
                res+= (long)right- (long)left;
                left++;
                
                
                //Console.WriteLine(string.Join(",",arr));
            }
            else if(arr[left] =='0')
            {
                left++;
            }
            right++;
            

        }
        return res;
        
    }
}