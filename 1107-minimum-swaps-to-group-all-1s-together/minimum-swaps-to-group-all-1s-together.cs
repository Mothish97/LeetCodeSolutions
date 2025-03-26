public class Solution {
    public int MinSwaps(int[] data) 
    {   
        var slid = data.Count(c=>c==1);
        if(slid ==0 || slid ==1) return 0;
        var count = data.Skip(0).Take(slid).Count(x=> x==0);
        var result = count;
        
        for (int i = slid; i < data.Length; i++)
        {
            if (data[i - slid] == 0) count--; // element leaving window
            if (data[i] == 0) count++;        // element entering window

            result = Math.Min(result, count);
        }
        return result;
    }
}