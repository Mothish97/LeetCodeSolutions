public class LRUCache 
{
    public  Dictionary<int,int> dct = new Dictionary<int,int>();
    public  LinkedList<int> ll =new LinkedList<int>();
    public Dictionary<int,LinkedListNode<int>> map =  new Dictionary<int,LinkedListNode<int>>();
    private int capacity;

    public LRUCache(int cap) 
    {
        capacity = cap;
    }
    
    public int Get(int key) 
    {
        if(dct.ContainsKey(key))
        {
            var node = map[key];
            ll.Remove(node);
            var nd = ll.AddFirst(node.Value);
            map[key]= nd;
            return dct[key];
        }
        return -1;
    }
    
    public void Put(int key, int value) 
    {

        if(dct.ContainsKey(key))
        {
            dct[key] = value;
        }
        else
        {
            dct.Add(key,value);
        }
        if(map.ContainsKey(key))
        {
            var node  = map[key];
            ll.Remove(node);
            var nd = ll.AddFirst(node.Value);
            map[key] = nd;
        }
        else{
            var nd = ll.AddFirst(key);
            map.Add(key,nd);
        }
    
        if(capacity < dct.Count())
        {
            var nodeLast = ll.Last;
            ll.Remove(nodeLast);
            map.Remove(nodeLast.Value);
            dct.Remove(nodeLast.Value);

        }
    }
}

/**
 * Your LRUCache object will be instantiated and called as such:
 * LRUCache obj = new LRUCache(capacity);
 * int param_1 = obj.Get(key);
 * obj.Put(key,value);
 */