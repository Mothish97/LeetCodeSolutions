public class MinStack {

    private List<int> list;
    public MinStack() 
    {
        list = new List<int>();
        
    }
    
    public void Push(int val) 
    {
        list.Add(val);
        
    }
    
    public void Pop() 
    {
        if(list.Count>0)
        {
            list.RemoveAt(list.Count-1);
        }
    }
    
    public int Top()
    {
        if(list.Count>0)
        {
            return list[list.Count-1];
        }
        return 0;
    }
    
    public int GetMin() 
    {
        return list.Min();
    }
}

/**
 * Your MinStack object will be instantiated and called as such:
 * MinStack obj = new MinStack();
 * obj.Push(val);
 * obj.Pop();
 * int param_3 = obj.Top();
 * int param_4 = obj.GetMin();
 */