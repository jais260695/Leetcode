public class MinStack {
    public class Pair
    {
        public int val;
        public int min;
        public Pair(int v, int m)
        {
            val = v;
            min = m;
        }
    }
    public Stack<Pair> st;

    /** initialize your data structure here. */
    public MinStack() {
        st = new Stack<Pair>();
    }
    
    public void Push(int x) {
        int minVal = int.MaxValue;
        if(st.Count()>0) minVal = st.Peek().min;
        Pair p = new Pair(x,x);
        
        if(x>minVal)
        {
            p.min = minVal;
        }
        st.Push(p);
    }
    
    public void Pop() {
        st.Pop();
    }
    
    public int Top() {
        return st.Peek().val;
    }
    
    public int GetMin() {
        return st.Peek().min;
    }
}

/**
 * Your MinStack object will be instantiated and called as such:
 * MinStack obj = new MinStack();
 * obj.Push(x);
 * obj.Pop();
 * int param_3 = obj.Top();
 * int param_4 = obj.GetMin();
 */