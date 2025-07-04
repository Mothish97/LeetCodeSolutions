public class Solution {
    public int[] ExclusiveTime(int n, IList<string> logs) 
    {
        var res = new int[n];
        var dct = new Dictionary<int,List<int>>();
        var stck = new Stack<(int func,int time)>();
        var lstTime =0;
        var lastFunction =0;
        foreach(var log in logs)
        {
            var lst = log.Split(":");
            var function   =int.Parse(lst[0]);
            var isStart = (lst[1]== "start" ? true : false);
            var time = int.Parse(lst[2]);


            if(isStart)
            {
                if(stck.Count ==0)
                {
                    stck.Push((function,time));
                }
                else
                {
                    var last = stck.Pop();
                    res[last.func] += time - last.time ;
                    stck.Push((last.func,res[last.func]));
                    stck.Push((function,time));
                }
            }
            else
            {
                var last = stck.Peek();
                if(last.func == function)
                {
                    res[function] += time - last.time +1;
                    stck.Pop();
                    if(stck.Count>0)
                    {
                        var recur = stck.Pop();
                        recur.time = time+1;
                        stck.Push(recur);
                    }

                }

            }

          


        }
        return res;
        
    }
}