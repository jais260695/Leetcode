public class CustomStack {

    public List<int> st = new List<int>();
    public int size;
    public CustomStack(int maxSize) {
        size = maxSize;
    }
    
    public void Push(int x) {
        if(st.Count()<size)
        {
            st.Add(x);
        }
    }
    
    public int Pop() {
        if(st.Count()==0) return -1;
        int val = st[st.Count()-1];
        st.RemoveAt(st.Count()-1);
        return val;
    }
    
    public void Increment(int k, int val) {
        for(int i=0;i<k&&i<st.Count();i++)
        {
            st[i]+=val;
        }
    }
}

/**
 * Your CustomStack object will be instantiated and called as such:
 * CustomStack obj = new CustomStack(maxSize);
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * obj.Increment(k,val);
 */