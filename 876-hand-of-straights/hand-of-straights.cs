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

        foreach (int start in hand)           
        {
            if (dct[start] == 0) continue;     

            // try to build one group [start, start+1, …, start+groupSize‑1]
            for (int offset = 0; offset < groupSize; offset++)
            {
                int card = start + offset;
                if (!dct.TryGetValue(card, out int cnt) || cnt == 0)
                    return false;                   // missing card

                dct[card] = cnt - 1;               // consume one
            }
        }
        return true;

        
    }
}