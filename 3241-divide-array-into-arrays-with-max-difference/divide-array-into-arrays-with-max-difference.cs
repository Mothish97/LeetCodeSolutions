public class Solution {
    public int[][] DivideArray(int[] nums, int k) {
        Array.Sort(nums);
        Console.WriteLine(string.Join(",",nums));
        var res = new  List<List<int>>();
        var cur = new List<int>();
        var right =0;
        while(right < nums.Count())
        {
            
            if(cur.Count()==0)
            {
                cur.Add(nums[right]);
                right++;
                continue;
            }
            if(cur.Count() == 3)
            {
                res.Add(new List<int> (cur));
                Console.WriteLine(string.Join(",",cur));
                Console.WriteLine(right);
                cur.Clear();
                continue;
            }
            if(nums[right] - cur[0]  <= k)
            {
                cur.Add(nums[right]);
                right++;
            }
            else
            {
                return [];
            }
            

        }
        if(cur[2] - cur[0]  > k)
        {
            return [];
        }
        res.Add(new List<int> (cur));

        return res.Select(inner => inner.ToArray()).ToArray();
    }
}