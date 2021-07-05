public class StockSpanner {
    
    Stack<int> st;
    List<int> list;
    int index;

    public StockSpanner() {
        st = new Stack<int>();
        list = new List<int>();
        index = 0;
    }
    
    public int Next(int price) {
        list.Add(price);
        index++;
        
        if(st.Count()==0 || list[st.Peek()-1]>price)
        {
            st.Push(index);
            return 1;
        }
        
        while(st.Count()>0 && list[st.Peek()-1]<=price)
        {
            st.Pop();
        }
        
        int res = index - (st.Count()==0? 0: st.Peek());        
        st.Push(index);
        
        return res;
    }
}

/**
 * Your StockSpanner object will be instantiated and called as such:
 * StockSpanner obj = new StockSpanner();
 * int param_1 = obj.Next(price);
 */