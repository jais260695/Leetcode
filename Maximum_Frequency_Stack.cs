public class FreqStack {

    public class ComparerPQ : IComparer<Tuple<int,int>>
    {
        public int Compare(Tuple<int,int> t1, Tuple<int,int> t2)
        {
            if(t1.Item1==t2.Item1)
            {
                return t2.Item2.CompareTo(t1.Item2);
            }
            else
            {
                return t2.Item1.CompareTo(t1.Item1);
            }
        }
    }
    
    Dictionary<int,int> dict = new Dictionary<int,int>();
    PriorityQueue<int,Tuple<int,int>> pq = new PriorityQueue<int,Tuple<int,int>>((new ComparerPQ()));
    int i = 0;
    public FreqStack() {
        
    }
    
    public void Push(int val) {
        if(!dict.ContainsKey(val))
        {
            dict.Add(val,1);
        }
        else
        {
            dict[val]++;
        }
        
        pq.Enqueue(val,new Tuple<int,int>(dict[val],i));
        i++;
    }
    
    public int Pop() {
        int t = pq.Dequeue();
        dict[t]--;
        return t;
    }
}

/**
 * Your FreqStack object will be instantiated and called as such:
 * FreqStack obj = new FreqStack();
 * obj.Push(val);
 * int param_2 = obj.Pop();
 */