public class SeatManager {
    
    PriorityQueue<int,int> pq;

    public SeatManager(int n) {
        pq = new PriorityQueue<int,int>();
        
        for(int i=1;i<=n;i++)
        {
            pq.Enqueue(i,i);
        }
    }
    
    public int Reserve() {
        return pq.Dequeue();
    }
    
    public void Unreserve(int seatNumber) {
        pq.Enqueue(seatNumber,seatNumber);
    }
}

/**
 * Your SeatManager object will be instantiated and called as such:
 * SeatManager obj = new SeatManager(n);
 * int param_1 = obj.Reserve();
 * obj.Unreserve(seatNumber);
 */