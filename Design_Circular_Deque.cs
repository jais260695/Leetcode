public class MyCircularDeque {
    
    List<int> list = new List<int>();
    int maxSize;
    int size;

    /** Initialize your data structure here. Set the size of the deque to be k. */
    public MyCircularDeque(int k) {
        maxSize = k;
        size = 0;
    }
    
    /** Adds an item at the front of Deque. Return true if the operation is successful. */
    public bool InsertFront(int value) {
        if(size==maxSize) return false;
        list.Insert(0,value);
        size++;
        return true;
    }
    
    /** Adds an item at the rear of Deque. Return true if the operation is successful. */
    public bool InsertLast(int value) {
        if(size==maxSize) return false;
        list.Add(value);
        size++;
        return true;
    }
    
    /** Deletes an item from the front of Deque. Return true if the operation is successful. */
    public bool DeleteFront() {
        if(size==0) return false;
        list.RemoveAt(0);
        size--;
        return true;
    }
    
    /** Deletes an item from the rear of Deque. Return true if the operation is successful. */
    public bool DeleteLast() {
        if(size==0) return false;
        list.RemoveAt(size-1);
        size--;
        return true;
    }
    
    /** Get the front item from the deque. */
    public int GetFront() {
        if(size==0) return -1;
        return list[0];
    }
    
    /** Get the last item from the deque. */
    public int GetRear() {
        if(size==0) return -1;
        return list[size-1];
    }
    
    /** Checks whether the circular deque is empty or not. */
    public bool IsEmpty() {
        return size==0;
    }
    
    /** Checks whether the circular deque is full or not. */
    public bool IsFull() {
        return size==maxSize;
    }
}

/**
 * Your MyCircularDeque object will be instantiated and called as such:
 * MyCircularDeque obj = new MyCircularDeque(k);
 * bool param_1 = obj.InsertFront(value);
 * bool param_2 = obj.InsertLast(value);
 * bool param_3 = obj.DeleteFront();
 * bool param_4 = obj.DeleteLast();
 * int param_5 = obj.GetFront();
 * int param_6 = obj.GetRear();
 * bool param_7 = obj.IsEmpty();
 * bool param_8 = obj.IsFull();
 */