public class Solution {
    public int IntegerReplacement(int n) 
    {
        var res = 0;
        n = Math.Abs(n);
        res = findOdd(n, 0);
        return res;
    }

    public int findOdd(long num, int lvl)
    {
        if(num == 1)
        {
            return lvl;
        }
        if(num%2 ==0)
        {
            return findOdd(num/2, lvl+1);
        }
        else
        {
            return Math.Min(findOdd(num+1, lvl+1) , findOdd(num-1, lvl+1));
        }

    }
}