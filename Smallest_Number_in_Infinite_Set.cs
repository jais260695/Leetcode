public class SmallestInfiniteSet {

    PriorityQueue<int,int> heap;
    HashSet<int> map;
    int curr;

    public SmallestInfiniteSet() {
        heap = new PriorityQueue<int,int>();
        map = new HashSet<int>();
        curr = 1;
    }
    
    public int PopSmallest() {
        if(heap.Count>0 && heap.Peek()<curr)
        {
            map.Remove(heap.Peek());
            return heap.Dequeue();
        }
        
        return curr++;
    }
    
    public void AddBack(int num) {
        if(!map.Contains(num) && num<curr)
        {
            map.Add(num);
            heap.Enqueue(num,num);
        }
    }
}

/**
 * Your SmallestInfiniteSet object will be instantiated and called as such:
 * SmallestInfiniteSet obj = new SmallestInfiniteSet();
 * int param_1 = obj.PopSmallest();
 * obj.AddBack(num);
 */