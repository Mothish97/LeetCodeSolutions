
public class LRUCache {

    public Dictionary<int,int> dct = new Dictionary<int,int>();
    public LinkedList<int> ld = new LinkedList<int>();
    public Dictionary<int,LinkedListNode<int>> map =  new Dictionary<int,LinkedListNode<int>>();

    public int cap=0;
    public LRUCache(int capacity) 
    {
        cap = capacity;     
    }
    
    public int Get(int key) 
    {
        if(dct.ContainsKey(key))
        {
            var node  = map[key];
            ld.Remove(node);
            var nd = ld.AddFirst(node.Value);
            map[key] = nd;
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
            ld.Remove(node);
            var nd = ld.AddFirst(node.Value);
            map[key] = nd;
        }
        else{
            var nd = ld.AddFirst(key);
            map.Add(key,nd);
        }

        //Remove if there is extra 
        if(dct.Count> cap)
        {
            var nodeLast = ld.Last;
            ld.Remove(nodeLast);
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