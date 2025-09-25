public class Solution {
    public int EvalRPN(string[] tokens) {
        var stck  = new Stack<string>();

        foreach(var s in tokens)
        {
            if(s == "*")
            {
                var fir = int.Parse(stck.Pop());
                var sec = int.Parse(stck.Pop());
                stck.Push((fir*sec).ToString());
            }
            else if(s == "+")
            {
                var fir = int.Parse(stck.Pop());
                var sec = int.Parse(stck.Pop());
                stck.Push((fir+sec).ToString());
            }
            else if(s == "-")
            {
                var fir = int.Parse(stck.Pop());
                var sec = int.Parse(stck.Pop());
                stck.Push((sec- fir).ToString());
            }
            else if(s == "/")
            {
                var fir = int.Parse(stck.Pop());
                var sec = int.Parse(stck.Pop());
                stck.Push((sec/fir).ToString());
            }
            else{
                stck.Push(s);
            }
        }
        return int.Parse(stck.Pop());
    }
}