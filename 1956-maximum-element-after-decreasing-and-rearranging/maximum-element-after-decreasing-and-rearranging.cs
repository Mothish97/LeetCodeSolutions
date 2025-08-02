public class Solution {
    public int MaximumElementAfterDecrementingAndRearranging(int[] arr) 
    {
        Array.Sort(arr);

        arr[0] =1;

        for(int i =1; i< arr.Count();i++)
        {
            var l = arr[i-1];
            var r = arr[i];
            if(r-l >1)
            {
                arr[i] = l+1;
            }
        }
        return arr[arr.Count()-1];
        
    }
}