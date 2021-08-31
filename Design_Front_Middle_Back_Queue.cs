public class FrontMiddleBackQueue {
    List<int> queue; 
    int size;
    public FrontMiddleBackQueue() {
        queue = new List<int>();
        size = 0;
    }
    
    public void PushFront(int val) {
        queue.Insert(0,val);
        size++;
    }
    
    public void PushMiddle(int val) {
        queue.Insert(size/2,val);
        size++;
    }
    
    public void PushBack(int val) {
        queue.Add(val);
        size++;
    }
    
    public int PopFront() {
        if(size==0) return -1;
        size--;  
        int res = queue[0];
        queue.RemoveAt(0); 
        return res;
    }
    
    public int PopMiddle() {
        if(size==0) return -1;
        size--; 
        int res = queue[size/2];
        queue.RemoveAt(size/2);
        return res;
    }
    
    public int PopBack() {
        if(size==0) return -1;
        size--;
        int res = queue[size];
        queue.RemoveAt(size);
        return res;
    }
}

/**
 * Your FrontMiddleBackQueue object will be instantiated and called as such:
 * FrontMiddleBackQueue obj = new FrontMiddleBackQueue();
 * obj.PushFront(val);
 * obj.PushMiddle(val);
 * obj.PushBack(val);
 * int param_4 = obj.PopFront();
 * int param_5 = obj.PopMiddle();
 * int param_6 = obj.PopBack();
 */