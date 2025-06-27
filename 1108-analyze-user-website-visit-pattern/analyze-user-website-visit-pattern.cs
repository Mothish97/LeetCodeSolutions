public class Solution {
    public IList<string> MostVisitedPattern(string[] username, int[] timestamp, string[] website) 
    {
        var records = new List<(string user, int time, string site)>();

        // Step 1: Combine all records
        for (int i = 0; i < username.Length; i++)
            records.Add((username[i], timestamp[i], website[i]));

        // Step 2: Sort by time
        records.Sort((a, b) => a.time.CompareTo(b.time));

        // Step 3: Group visits per user
        var userVisits = new Dictionary<string, List<string>>();
        foreach (var record in records)
        {
            if (!userVisits.ContainsKey(record.user))
                userVisits[record.user] = new List<string>();
            userVisits[record.user].Add(record.site);
        }

        // Step 4: Count unique 3-sequence patterns per user
        var freq = new Dictionary<string, int>();

        foreach (var kvp in userVisits)
        {
            var user = kvp.Key;
            var sites = kvp.Value;
            var seen = new HashSet<string>();

            for (int i = 0; i < sites.Count; i++)
            {
                for (int j = i + 1; j < sites.Count; j++)
                {
                    for (int k = j + 1; k < sites.Count; k++)
                    {
                        var pattern = $"{sites[i]},{sites[j]},{sites[k]}";
                        if (seen.Add(pattern))
                        {
                            if (!freq.ContainsKey(pattern))
                                freq[pattern] = 0;
                            freq[pattern]++;
                        }
                    }
                }
            }
        }

        // Step 5: Find pattern with max frequency and lex smallest
        return freq
            .OrderByDescending(p => p.Value)
            .ThenBy(p => p.Key)
            .First()
            .Key
            .Split(',')
            .ToList();
    }
}
