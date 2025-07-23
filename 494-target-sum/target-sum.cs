public class Solution {
    public int count =0;
    public int FindTargetSumWays(int[] nums, int target) 
    {
        dfs(nums,0,target,0);
        return count;
    }

    public void dfs(int [] nums,int path, int target, int lvl)
    {
        if(path== target && lvl == nums.Count()) 
        {
            count++;
        }

        if(lvl >=nums.Count() )
        {
            return;
        }

        
        dfs(nums, path + nums[lvl], target, lvl+1);
        dfs(nums, path -nums[lvl], target, lvl+1);
        



    }
}