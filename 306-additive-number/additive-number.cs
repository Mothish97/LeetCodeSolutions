public class Solution {
    public bool dfs(string num, BigInteger num1, BigInteger num2, int index, int count)
    {
        if (index >= num.Length)
        {
            return count >= 3;
        }

        BigInteger num3 = num1 + num2;
        string num3Str = num3.ToString();

        // Check if remaining string is long enough
        if (index + num3Str.Length > num.Length) return false;

        string nextPart = num.Substring(index, num3Str.Length);
        if (nextPart != num3Str) return false;

        return dfs(num, num2, num3, index + num3Str.Length, count + 1);
    }

    public bool IsAdditiveNumber(string num)
    {
        for(int i =1; i<= num.Length-2;i++)
        {
            for(int j = i+1 ;j<=num.Length-1;j++)
            {
                var num1 = num.Substring(0,i);
                var num2 = num.Substring(i,j-i);
                if ((num1.Length > 1 && num1.StartsWith("0")) || (num2.Length > 1 && num2.StartsWith("0")))
                    continue;

                BigInteger num1l = BigInteger.Parse(num1);
                BigInteger num2l = BigInteger.Parse(num2);
                if(dfs(num, num1l, num2l, j, 2))
                {
                    return true;
                }
            }
        }
        return false;
        
    }
}