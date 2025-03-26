public class Solution {
    public int MinSwaps(int[] data) 
    {   
        var slid = data.Count(c=>c==1);
        if(slid ==0 || slid ==1) return 0;
        var count = data.Skip(0).Take(slid).Count(x=> x==0);
        var result = count;
        
        for(int i =0;i<=data.Length-slid-1;i++)
        {
            if(data[i] == 0) count--;
            if(data[i+slid]==0) count++;
            result = Math.Min(count,result);
        }
        return result;
    }
}