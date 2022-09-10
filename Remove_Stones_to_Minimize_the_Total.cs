public class Solution {
    public class Comparer : IComparer<int>
    {
        public int Compare(int a, int b)
        {
            return b-a;
        }
    }
    public int MinStoneSum(int[] piles, int k) {
        int n = piles.Count();
        
        PriorityQueue<int,int> pq = new PriorityQueue<int,int>(new Comparer());
        
        for(int i=0;i<n;i++)
        {
            pq.Enqueue(piles[i],piles[i]);
        }
        
        for(int i=0;i<k;i++)
        {
            int pile = pq.Dequeue();
            
            pile -= (pile/2);
            
            pq.Enqueue(pile,pile);
        }
        
        int result = 0;
        
        while(pq.TryDequeue(out int pile, out int prty))
        {
            result+=pile;
        }
        
        return result;
    }
}