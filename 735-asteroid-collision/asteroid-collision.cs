public class Solution {
    public int[] AsteroidCollision(int[] asteroids) 
    {
        var stck = new Stack<int>();

        foreach(var a in asteroids )
        {
            if(stck.Count() == 0 || a>=0)
            {
                stck.Push(a);
                continue;
            }
            if(stck.Peek()<0 && a<0)
            {
                stck.Push(a);
                continue;
            }

            while(stck.Count()>0 && stck.Peek()< Math.Abs(a) && stck.Peek()>=0)
            {
                stck.Pop();
            }

            if(stck.Count()==0 || (stck.Count()>0 && stck.Peek()<0))
            {
                stck.Push(a);
            }
            
            if(stck.Peek() == Math.Abs(a)  && stck.Peek()>=0){
                stck.Pop();
            }

            
        }
        return stck.Reverse().ToArray();
        
    }
}