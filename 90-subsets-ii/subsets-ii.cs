public class Solution {
    private List<IList<int>> res = new List<IList<int>>();
    private HashSet<string> seen = new HashSet<string>();

    public IList<IList<int>> SubsetsWithDup(int[] nums) {
        Array.Sort(nums); // important for handling duplicates consistently
        dfs(nums, new List<int>(), 0);
        return res;
    }

    private void dfs(int[] nums, List<int> path, int lvl) {
        // serialize path to string
        string key = string.Join(",", path);

        if (!seen.Contains(key)) {
            res.Add(new List<int>(path));
            seen.Add(key);
        }

        for (int i = lvl; i < nums.Length; i++) {
            path.Add(nums[i]);
            dfs(nums, path, i + 1);
            path.RemoveAt(path.Count - 1);
        }
    }
}
