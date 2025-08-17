public class Solution {
    public IList<IList<int>> PermuteUnique(int[] nums) 
    {
        var res = new List<IList<int>>();
        dfs(nums,0,res,new List<int>(), new HashSet<int>(), new HashSet<string>(),"");
        
        return res;
    }

    void dfs(int[] nums,int ind, List<IList<int>> res, List<int> path, HashSet<int> visit,HashSet<string> added,string pt )
    {
        if(ind> nums.Count())
        {
            return;
        }
        if(path.Count() == nums.Count() && !added.Contains(pt))
        {
            added.Add(pt);
            res.Add(new List<int>(path));
        }

        for(int i = 0; i<nums.Count();i++)
        {
            if(visit.Contains(i)) continue;
            visit.Add(i);
            path.Add(nums[i]);
            string add = nums[i].ToString() + ",";
            pt += add;

            dfs(nums, i, res, path, visit, added, pt);

            pt = pt.Substring(0, pt.Length - add.Length);
            path.RemoveAt(path.Count()-1);
            visit.Remove(i);
        }
    }
 
}