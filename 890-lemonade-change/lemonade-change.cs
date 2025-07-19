public class Solution {
    public bool LemonadeChange(int[] bills) 
    {

        var ct5 =0;
        var ct10 =0;
        var ct20=0;
        foreach(var b in bills)
        {
            if(b == 5)
            {
                ct5++;
            }
            else if(b ==10)
            {
                ct5--;
                ct10++;
            }
            else
            {
                if(ct10>0)
                {
                    ct10--;
                    ct5--;
                }
                else
                {
                    ct5--;
                    ct5--;
                    ct5--;
                }
                
                ct20++;
            }
            // Console.WriteLine($"ct5 {ct5} ct10 {ct10} ct20 {ct20}");
            if(ct5 <0 || ct10<0 || ct20<0) return false;
        }
        return true;
    }
}