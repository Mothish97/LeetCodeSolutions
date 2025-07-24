public class Solution {
    public IList<IList<int>> Subsets(int[] nums) 
    {
        var res = new List<IList<int>>();
        dfs(nums,0,new List<int> (),res);
        return res;
    }

    public void dfs(int [] nums,int lvl, List<int> path, List<IList<int>> res)
    {
        //Console.WriteLine(string.Join(",",path));
        res.Add(new List<int>(path));
        if(lvl >= nums.Count())
        {
            return;
        }
        
        
        for(int i = lvl; i<nums.Count() ;i++)
        {
            path.Add(nums[i]);
            dfs(nums,i+1,path ,res);
            path.Remove(nums[i]);
        }
    }
}