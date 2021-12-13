public class MyQueue {
    Stack<int> q1 = new Stack<int>();
    Stack<int> q2 = new Stack<int>();

    /** Initialize your data structure here. */
    public MyQueue() {
        
    }
    
    /** Push element x to the back of queue. */
    public void Push(int x) {
            q1.Push(x);
    }
    
    /** Removes the element from in front of queue and returns that element. */
    public int Pop() {
            while(q1.Count()!=0)
            {
                q2.Push(q1.Pop());
            }
         int val = q2.Pop();
        
        while(q2.Count()!=0)
        {
            q1.Push(q2.Pop());
        }
        
        return val;
    }
    
    /** Get the front element. */
    public int Peek() {
            while(q1.Count()!=0)
            {
                q2.Push(q1.Pop());
            }
            int val = q2.Peek();
        
        while(q2.Count()!=0)
        {
            q1.Push(q2.Pop());
        }
        return val;
    }
    
    /** Returns whether the queue is empty. */
    public bool Empty() {
        if(q1.Count()==0)
            return true;
        return false;
    }
}

/**
 * Your MyQueue object will be instantiated and called as such:
 * MyQueue obj = new MyQueue();
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * int param_3 = obj.Peek();
 * bool param_4 = obj.Empty();
 */