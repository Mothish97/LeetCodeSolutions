public class Solution {
    public bool CanBeValid(string s, string locked) 
    {
        int n = s.Length;
        if(s.Count()%2 ==1) return false;
        var lockst = new Stack<int>();
        var unlock = new Stack<int>();

        for(int i =0; i< n;i++)
        {
            if(locked[i] == '0')
            {
                unlock.Push(i);
            }

            else if(s[i] == '(')
            {
                lockst.Push(i);
            }
            else  if(s[i] == ')')
            {
                if(lockst.Count>0)
                {
                    lockst.Pop();
                }
                else if(unlock.Count>0)
                {
                    unlock.Pop();
                }
                else{
                    return false;
                }
            }
            
 
        }
        
        while(lockst.Count > 0 &&
            unlock.Count > 0 && unlock.Peek()> lockst.Peek())
        {
                lockst.Pop();
                unlock.Pop();
        }


        if(lockst.Count>0) return false;

        return true;

    }
}