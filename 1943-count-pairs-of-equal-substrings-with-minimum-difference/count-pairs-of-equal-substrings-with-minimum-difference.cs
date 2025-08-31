using System;
using System.Collections.Generic;

public class Solution {
    public int CountQuadruples(string fir, string sec) 
    {
        int n = fir.Length, m = sec.Length;
        if (n == 0 || m == 0) return 0;

        var dct1 = new Dictionary<int, int>(n); // first occurrence in fir
        var dct2 = new Dictionary<int, int>(m); // last  occurrence in sec

        // first occurrence map
        for (int i = 0; i < n; i++)
        {
            int key = fir[i];
            dct1.TryAdd(key, i);
        }

        // last occurrence map
        for (int j = 0; j < m; j++)
        {
            int key = sec[j];
            dct2[key] = j;
        }

        int minDiff = int.MaxValue;
        int ct = 0;

        foreach (var kv in dct1)
        {
            int key = kv.Key;
            int firstIdx = kv.Value;

            if (!dct2.TryGetValue(key, out int lastIdx)) continue;

            int diff = firstIdx - lastIdx;
            if (diff < minDiff)
            {
                minDiff = diff;
                ct = 1;
            }
            else if (diff == minDiff)
            {
                ct++;
            }
        }

        return ct;
    }
}
