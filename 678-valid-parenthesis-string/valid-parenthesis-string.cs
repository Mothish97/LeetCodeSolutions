public class Solution {
    public bool CheckValidString(string s) 
    {
        var lck = new Stack<(char val,int idx)>();
        var unlock = new Stack<(char val,int idx)>();

        for(int i =0 ; i< s.Count();i++)
        {
            if(s[i] == '(')
            {
                lck.Push(('(',i));
                //Console.WriteLine($"Pushed to lck ( at idx{i}");
            }
            else if (s[i] == ')')
            {
                if(lck.Count>0)
                {
                    //Console.WriteLine($"Popped lck");
                    lck.Pop();
                }
                else if(unlock.Count()>0)
                {
                    //Console.WriteLine($"Popped unlock");
                    unlock.Pop();
                }
                else{
                    return false;
                }
            }
            else{
                //Console.WriteLine($"Pushed to unlock * at idx{i}");
                unlock.Push(('*',i));
            }

            //Console.WriteLine($"lck Count {lck.Count()}");
             //Console.WriteLine($"unlock Count {unlock.Count()}");
              //Console.WriteLine($"---------------------------------------");
        }
        while(lck.Count()>0 && unlock.Count()>0)
        {
            if(lck.Peek().idx < unlock.Peek().idx)
            {
                lck.Pop();
                unlock.Pop();
            }
            else{
                //Console.WriteLine("1");
                return false;
            }
        }
       // Console.WriteLine("2");
        if(lck.Count()>0) return false;
        //Console.WriteLine("3");
        return true;
        
    }
}