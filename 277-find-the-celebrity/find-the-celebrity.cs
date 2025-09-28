/* The Knows API is defined in the parent class Relation.
      bool Knows(int a, int b); */

public class Solution : Relation {
    public int FindCelebrity(int n) 
    {
        var dct = new Dictionary<int, HashSet<int>>();
        var visit = new HashSet<int>();

        for(int i =0; i<n;i++)
        {
            dct.Add(i,new HashSet<int>());
        }
        for(int i =0; i<n;i++)
        {
            if(!visit.Contains(i) )
            {
                dfs(i);
            }
        }
        void dfs(int a)
        {
            if(visit.Contains(a)) return;
            visit.Add(a);
            for(int i =0; i<n;i++)
            {
                if(Knows(a,i) && i != a) 
                {
                    dct[i].Add(a);
                    dfs(i);
                }
            }
        }
        int ans = -1;
        bool found = false;

        foreach (var kv in dct)
        {
            // use Count property on HashSet (faster than LINQ Count())
            if (kv.Value.Count == n - 1)    // everyone knows kv.Key
            {
                if (found) return -1;       // more than one such person -> impossible
                ans = kv.Key;
                found = true;
            }
        }

        if (!found) return -1;

        // MISSING CHECK: the celebrity must know nobody
        for (int i = 0; i < n; i++)
        {
            if (i == ans) continue;
            if (Knows(ans, i)) return -1;   // candidate knows someone -> not a celeb
        }

        return ans;

    }
}