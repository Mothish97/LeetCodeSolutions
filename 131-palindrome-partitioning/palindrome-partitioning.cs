public class Solution {
    public List<IList<string>> res = new List<IList<string>> ();
    public IList<IList<string>> Partition(string s) 
    {
        dfs(s, new List<string>(), 0);
        return res;
        
    }

    public void dfs(string s, List<string> path, int lvl)
    {
        if(lvl > s.Length)
        {
            return;
        }

        if(lvl == s.Length)
        {
            res.Add(new List<string>(path));
            return;
        }
        var cur = "";
        for(int i = lvl; i< s.Length; i++)
        {
            cur += s[i].ToString();
            if(isp(cur))
            {
                path.Add(cur);
                dfs(s,path,i+1);
                path.RemoveAt(path.Count()-1);
            }
        }
    }

    public bool isp(string s)
{
    if (string.IsNullOrEmpty(s)) return false;

    int left = 0;
    int right = s.Length - 1;

    while (left < right)
    {
        if (s[left] != s[right])
            return false;

        left++;
        right--;
    }

    return true;
}

}