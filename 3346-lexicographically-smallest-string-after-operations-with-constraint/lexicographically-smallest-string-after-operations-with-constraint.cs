public class Solution {
    public string GetSmallestString(string s, int k) {
        var res = new StringBuilder();
        if(k == 0 ) return s;
        foreach(var c in s)
        {
            Console.WriteLine(k);
            if(c =='a')
            {
                res.Append("a");
                continue;
            }
            var num =  c - 'a';
            var right = 26 - num;
            var left = num;
            if(k>0)
            {
                if(left< right && k >=left)
                {   
                    res.Append("a");
                    k-= left;
                }
                else if(left> right && k >=right)
                {
                    res.Append("a");
                    k-= right;
                }
                else if(left == right && k >=right ){
                    res.Append("a");
                    k-= right;
                }
                else
                {
                    num = num -k;
                    var ch = (char)('a' + num );
                    res.Append(ch.ToString());
                    k =0;
                }
            }
            else
            {
                res.Append(c.ToString());
            }

        }
        return res.ToString();
    }
}