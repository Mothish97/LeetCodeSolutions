public class Solution {
    public int MinimumDeletions(string word, int k) 
    {
        var freq = new Dictionary<char, int>();
        foreach (char c in word)
        {
            if (!freq.ContainsKey(c)) freq[c] = 0;
            freq[c]++;
        }

        var freqs = freq.Values.OrderBy(x => x).ToList();
        int n = freqs.Count;
        int minDeletions = int.MaxValue;

        for (int i = 0; i < n; i++)
        {
            int target = freqs[i];
            int deletions = 0;

            // Remove all frequencies less than target
            for (int j = 0; j < i; j++)
                deletions += freqs[j];

            // For frequencies greater than target + k, reduce them
            for (int j = i; j < n; j++)
            {
                if (freqs[j] > target + k)
                    deletions += freqs[j] - (target + k);
            }

            minDeletions = Math.Min(minDeletions, deletions);
        }

        return minDeletions;
    }
}
