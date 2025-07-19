public class Solution {
    public bool IsNStraightHand(int[] hand, int groupSize) 
    {
        
        if(hand.Count() % groupSize != 0) return false;
        Array.Sort(hand);
        var hnd = hand.ToList();
        var i =0;
        while(hnd.Count()>0)
        {
            
            
            var first = hnd[0];
            hnd.RemoveAt(0);
            for(int j=1; j<groupSize;j++)
            {
                first++;
                if(hnd.Contains(first))
                {
                    hnd.Remove(first);
                }
                else{
                    return false;
                }
            }
            //Console.WriteLine(string.Join(",",hnd));

            i++;

        }
        return true;

        
    }
}