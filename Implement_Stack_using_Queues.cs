public class MyStack {
    
    Queue<int> q1 = new Queue<int>();
    Queue<int> q2 = new Queue<int>();

    /** Initialize your data structure here. */
    public MyStack() {
        
    }
    
    /** Push element x onto stack. */
    public void Push(int x) {
        if(q1.Count==0)
            q2.Enqueue(x);
        else
            q1.Enqueue(x);
    }
    
    /** Removes the element on top of the stack and returns that element. */
    public int Pop() {
        if(q2.Count()==0)
        {
            while(q1.Count()!=1)
            {
                q2.Enqueue(q1.Dequeue());
            }
        
            return q1.Dequeue();
        }
        
        while(q2.Count()!=1)
        {
            q1.Enqueue(q2.Dequeue());
        }
        
        return q2.Dequeue();
    }
    
    /** Get the top element. */
    public int Top() {
        if(q2.Count()==0)
        {
            while(q1.Count()!=1)
            {
                q2.Enqueue(q1.Dequeue());
            }
        
            int val1 = q1.Dequeue();
            q2.Enqueue(val1);
            return val1;
        }
        
        while(q2.Count()!=1)
        {
            q1.Enqueue(q2.Dequeue());
        }
        
        int val = q2.Dequeue();
        q1.Enqueue(val);
        return val;
        
    }
    
    /** Returns whether the stack is empty. */
    public bool Empty() {
        if(q1.Count()==0 && q2.Count()==0)
            return true;
        return false;
    }
}

/**
 * Your MyStack object will be instantiated and called as such:
 * MyStack obj = new MyStack();
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * int param_3 = obj.Top();
 * bool param_4 = obj.Empty();
 */