public class Solution {
    public string ParseTernary(string exp)
    {
        var stck = new Stack<char>();
        var ct = exp.Count()-1;
        for(int i =ct; i>0;i--)
        {
            if(exp[i] == '?')
            {
                var tru = stck.Pop();
                stck.Pop();
                var fal = stck.Pop();
                var cond = exp[--i];
                if(cond == 'T')
                {
                    stck.Push(tru);
                }
                else{
                    stck.Push(fal);
                }
            }
            else{
                stck.Push(exp[i]);
            }
        }
        return stck.Pop().ToString();


    }
}