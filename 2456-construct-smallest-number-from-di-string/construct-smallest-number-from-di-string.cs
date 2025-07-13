public class Solution {
    public string SmallestNumber(string pat) {
        var stck = new Stack<(int val,int ind)>();
        var dct = new HashSet<int>();
        stck.Push((1,0));
        dct.Add(1);
        var s = 0;
        
        while(s< pat.Count())
        {
            var cur = stck.Peek().val;
            if(pat[s] == 'I')
            {
                while(dct.Contains(cur) && cur <= 9)
                {
                    cur++;
                }
                //Console.WriteLine($"Add {cur}");
                //Console.WriteLine($"--------------------");
                stck.Push((cur,s));
                dct.Add(cur);
                s++;
            }
            else
            {
                cur--;
                if(dct.Contains(cur) && cur !=0)
                {
                    var last = stck.Peek();
                    var add = 0;
                    Console.WriteLine($"cur {cur}");
                    while(stck.Peek().val != cur)
                    {
                        add++;
                        last = stck.Peek();
                        dct.Remove(stck.Peek().val);
                        Console.WriteLine($"Remove {stck.Peek().val}");
                        stck.Pop();
                    }
                    var ind = last.ind;
                    while(pat[ind] != 'I')
                    {
                        stck.Push((stck.Peek().val-1,ind));
                        dct.Add(stck.Peek().val);
                        Console.WriteLine($"Add {stck.Peek().val}");
                        ind++;
                    }
                    stck.Push((stck.Peek().val+add+1,ind));
                    dct.Add(stck.Peek().val);
                    Console.WriteLine($"Add {stck.Peek().val}");
                    s = ind+1;
                }  
                else if(cur ==0)
                {
                    var ct = stck.Count();
                    stck.Clear();
                    stck.Push((ct+1,0));
                    dct.Clear();
                    //Console.WriteLine($"Remove all");
                    s = 0;
                    dct.Add(stck.Peek().val);
                    //Console.WriteLine($"Add {stck.Peek().val}");
                } 
                else
                {
                    stck.Push((cur,s));
                    //Console.WriteLine($"Add {cur}");
                    dct.Add(stck.Peek().val);
                    s++;
                }
                Console.WriteLine($"--------------------");
            }

        }
        var res = new List<char>();
        while(stck.Count>0)
        {
            res.Add((char)('0' + stck.Pop().val));
        }
        res.Reverse();
        //Console.WriteLine(string.Join(",",res));
        return new string(res.ToArray());


    }
}