public class Solution {
    int ct =0;
    public IList<IList<int>> CombinationSum2(int[] candidates, int target)
    {
         ct = candidates.Count();
        Array.Sort(candidates);
        //Console.WriteLine(string.Join(",",candidates));
        var res = new HashSet<string> ();
        dfs(candidates,target, new List<int>(),0,res,0);
        //Console.WriteLine(string.Join(",",res));
 var result = res
            .Select(s => (IList<int>)s.Split(',').Select(int.Parse).ToList())
            .ToList();
        return result;
    }

    public void dfs(int[] cand,int target, List<int> path,int sum , HashSet<string> res,int lvl)
    {

        if(sum == target)
        {
            string result = string.Join(",", path);
            res.Add(result);
            return;
        }

        for(int i =lvl; i< ct;i++)
        {
             if (i > lvl && cand[i] == cand[i - 1]) continue;
            if(sum + cand[i]<= target)
            {
                path.Add(cand[i]);
                dfs(cand,target,path,sum+ cand[i],res,i+1);
                path.RemoveAt(path.Count()-1);
            }

        }

    }
}
