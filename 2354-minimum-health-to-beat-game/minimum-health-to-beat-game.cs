public class Solution {
    public long MinimumHealth(int[] damage, int armor) 
    {
        int maxVal = damage.Max();
        
        //
        if(maxVal< armor)
        {
            int index = Array.IndexOf(damage, maxVal);
            if (index != -1) // Ensure index is valid
            {
                damage[index] = 0;
            }
            long totalDamage = damage.Select(d => (long)d).Sum();
            return totalDamage +1;
        }
        else
        {
            int index = Array.IndexOf(damage, maxVal);
            if (index != -1) // Ensure index is valid
            {
                damage[index] = 0;
            } 
            long diff =(long) maxVal -(long) armor;
            long totalDamage = damage.Select(d => (long)d).Sum();
            return totalDamage +diff +1;
        }
        
    }
}