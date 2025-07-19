public class Solution {
    public bool IsNStraightHand(int[] hand, int groupSize) 
    {
        
        if(hand.Count() % groupSize != 0) return false;
        var dct = new SortedDictionary<int,int>();
        foreach(var d in hand)
        {
            if(dct.ContainsKey(d))
            {
                dct[d] ++;
            }
            else{
                dct.Add(d,1);
            }
        }
        dct.OrderBy(kvp => kvp.Value);

        while(dct.Count()>0)
        {         
            var first = dct.First().Key;
            for(int j=0; j<groupSize;j++)
            {
                if(dct.ContainsKey(first))
                {
                    dct[first]--;
                }
                else{
                    return false;
                }
                
                if(dct[first] == 0) dct.Remove(first);
                first++;
            }

        }
        return true;

        
    }
}