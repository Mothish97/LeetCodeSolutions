public class Solution {
    public long MinimumHealth(int[] damage, int armor) 
    {
        long maxVal = damage.Max(); 
        long totalDamage = damage.Sum(d => (long)d);
        long damageReduced = Math.Min(maxVal, armor);
        
        return totalDamage - damageReduced + 1;
        
    }
}