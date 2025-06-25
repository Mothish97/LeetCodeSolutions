public class Solution {
    public string ClearStars(string s) 
    {
        var dct = new Dictionary <char,List<int>>();
        var lst = s.ToCharArray().ToList();
        for(int i =0; i<lst.Count;i++)
        {
            if(lst[i] == '*')
            {
                var min = dct.Keys.Min();
                var ind = dct[min][dct[min].Count -1];
                dct[min].RemoveAt(dct[min].Count - 1); 
                lst[ind] = ' ';
                lst[i]=' ';
                if(dct[min].Count == 0)
                {
                    dct.Remove(min);
                }
            }
            else
            {
                if(dct.ContainsKey(lst[i]))
                {
                    dct[lst[i]].Add(i);
                }
                else{
                    dct.Add(lst[i],new List<int> {i});
                }
            }
        }
        var res = new StringBuilder();
        foreach(var l in lst)
        {
            if(l != ' ')
                res.Append(l);
        }

        return res.ToString().Trim();
        
    }
}