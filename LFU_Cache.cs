public class LFUCache {
    public class LinkedList
    {
        public int val;
        public LinkedList next;
        public LinkedList prev;
        public LinkedList(int val = 0,LinkedList next=null, LinkedList prev=null)
        {
            this.val = val;
            this.next = next;
            this.prev = prev;
        }
    }
    Dictionary<int,Tuple<int,int>> dict = new Dictionary<int,Tuple<int,int>>();
    LinkedList head = null;
    LinkedList tail = null;
    int capacity = 0; 
    int currCount = 0;
    void RemoveFromLinkedList(int key){
        LinkedList temp = head;
        while(temp!=null && temp.val!=key)
        {
            temp = temp.next;
        }

        if(temp!=null && temp.prev==null)
        {
            head = temp.next;
            if(head!=null)
                head.prev = null;
            return;
        }

        if(temp!=null && temp.next==null)
        {
            tail = temp.prev;
            if(tail!=null)
                tail.next = null;
            return;
        }
        
            
        temp.prev.next = temp.next;
        temp.next.prev = temp.prev;

                            
    }

    void RemoveFromTail()
    {
        bool isHeadTail = false;
        if(head==tail) isHeadTail = true;
        LinkedList temp = tail;
        tail =  temp.prev;
        if(tail!=null)
            tail.next = null;
        temp.prev = null;

        if(isHeadTail) head = tail;
    }

    void InsertInLinkedList(LinkedList node)
    {
        if(head==null)
        {
            head = node;
            tail = node;
            return;
        }
        LinkedList prev = null;
        LinkedList temp = head;
              
        while(temp!=null && dict[temp.val].Item2>dict[node.val].Item2)
        {
            prev = temp;
            temp = temp.next;
        }
        
        if(temp!=null && temp.prev==null)
        {
            
            node.next = head;
            node.prev = null;
            head.prev = node;
            head = node;
            return;

        }
        
        if(temp==null)
        {
            prev.next = node;
            node.prev = prev;
            tail = node;
            return;
        }

        prev.next = node;
        node.prev = prev;

        node.next = temp;
        temp.prev = node;
    }

    public LFUCache(int capacity) {
        this.capacity = capacity;
    }
    
    public int Get(int key) {
        if(!dict.ContainsKey(key)) return -1;

        RemoveFromLinkedList(key);
        dict[key] = new Tuple<int,int>(dict[key].Item1,dict[key].Item2+1);
        InsertInLinkedList(new LinkedList(key));
        return dict[key].Item1;
    }
    
    public void Put(int key, int value) {
        if(capacity==0) return;
        if(currCount==capacity)
        {
            if(!dict.ContainsKey(key))
            {
                dict.Remove(tail.val);
                RemoveFromTail();
                currCount--;
            }           
        }

        if(dict.ContainsKey(key))
        {
            RemoveFromLinkedList(key);
            dict[key] = new Tuple<int,int>(value, dict[key].Item2+1);
            InsertInLinkedList(new LinkedList(key));
        }
        else
        {
            dict.Add(key,new Tuple<int,int>(value,1));
            InsertInLinkedList(new LinkedList(key));
            currCount++;
        }
    }
}

/**
 * Your LFUCache object will be instantiated and called as such:
 * LFUCache obj = new LFUCache(capacity);
 * int param_1 = obj.Get(key);
 * obj.Put(key,value);
 */