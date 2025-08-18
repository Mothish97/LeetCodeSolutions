public class Solution {
    public IList<IList<int>> FindSubsequences(int[] nums) {
        var  res = new List<IList<int>>();
        dfs(nums,0,new List<int>(),res);
        return res;
    }

    public void dfs(int[] nums,int start,List<int> path, List<IList<int>> res )
    {
        if(path.Count()>1)
        {
            res.Add(new List<int>(path));
        }
        if(start >= nums.Count())
        {
            return;
        }

        var used = new HashSet<int>(); 
        
        for(int i = start ;i<nums.Count();i++)
        {
            if (used.Contains(nums[i])) continue;
            if(path.Count()>0 && path[path.Count()-1] > nums[i]) continue;
            path.Add(nums[i]);
            used.Add(nums[i]);
            dfs(nums,i+1,path,res);
            path.RemoveAt(path.Count()-1);
        }

    }
}