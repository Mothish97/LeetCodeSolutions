public class Solution {
    public bool IsNStraightHand(int[] hand, int groupSize) 
    {
        
        if(hand.Count() % groupSize != 0) return false;
        Array.Sort(hand);
        var dct = new Dictionary<int,int>();
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