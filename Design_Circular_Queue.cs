public class MyCircularQueue {
    
    List<int> list = new List<int>();
    int maxSize;
    int size;
    public MyCircularQueue(int k) {
        maxSize = k;
        size = 0;
    }
    
    public bool EnQueue(int value) {
        if(size==maxSize) return false;
        list.Add(value);
        size++;
        return true;
    }
    
    public bool DeQueue() {
        if(size==0) return false;
        list.RemoveAt(0);
        size--;
        return true;
    }
    
    public int Front() {
        if(size==0) return -1;
        return list[0];
    }
    
    public int Rear() {
        if(size==0) return -1;
        return list[size-1];
    }
    
    public bool IsEmpty() {
        return size==0;
    }
    
    public bool IsFull() {
        return size==maxSize;
    }
}

/**
 * Your MyCircularQueue object will be instantiated and called as such:
 * MyCircularQueue obj = new MyCircularQueue(k);
 * bool param_1 = obj.EnQueue(value);
 * bool param_2 = obj.DeQueue();
 * int param_3 = obj.Front();
 * int param_4 = obj.Rear();
 * bool param_5 = obj.IsEmpty();
 * bool param_6 = obj.IsFull();
 */