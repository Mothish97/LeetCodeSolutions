public class Solution {
    public int MaxTurbulenceSize(int[] arr) 
    {
        var left = 0;
        var right = 0;
        var res = 0;
        while(right<arr.Count())
        {
            if(right == arr.Count()-1)
            {
                Console.WriteLine($"left {left} right{right}");
                res=Math.Max(res , right-left+1);
                break;
            }
            if(right% 2 ==0 && arr[right] < arr[right+1])
            {
                right++;
            }
            else if(right% 2 != 0 && arr[right] > arr[right+1])
            {
                right++;
            }
            else{
                left ++;
                right =left;
            }
            res=Math.Max(res , right-left+1);
        }

        left = 0; right =0;
        while(right<arr.Count())
        {
            if(right == arr.Count()-1)
            {
                Console.WriteLine($"left {left} right{right}");
                res=Math.Max(res , right-left+1);
                break;
            }
            if(right% 2 ==0 && arr[right] > arr[right+1])
            {
                right++;
            }
            else if(right% 2 !=0 && arr[right] < arr[right+1])
            {
                right++;
            }
            else{
                left ++;
                right =left;
            }
            res=Math.Max(res , right-left+1);
        }
        return res;
        
    }
}