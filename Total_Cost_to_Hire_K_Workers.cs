public class Solution {
    public long TotalCost(int[] costs, int k, int candidates) {
        int n = costs.Count();
        PriorityQueue<int,int> pqLeft = new PriorityQueue<int,int>();
        PriorityQueue<int,int> pqRight = new PriorityQueue<int,int>();
        
        int l = 0;
        int r = n-1;
        
        int count = 0;
        while(count<candidates && l<=r)
        {
            pqLeft.Enqueue(costs[l],costs[l]);
            count++;
            l++;
        }
        
        
        count = 0;
        while(count<candidates && r>=l)
        {
            pqRight.Enqueue(costs[r],costs[r]);
            count++;
            r--;
        }
        
        
        
        count = 0;
        
        long result = 0;
        
        
        
        while(pqLeft.Count>0 && pqRight.Count>0)
        {
            int val = 0;
            if(pqLeft.Peek() <= pqRight.Peek())
            {
                val = pqLeft.Dequeue();
                if(l<=r)
                {
                    pqLeft.Enqueue(costs[l],costs[l]);
                    l++;
                }
            }
            else
            {
                val = pqRight.Dequeue();
                if(r>=l)
                {
                    pqRight.Enqueue(costs[r],costs[r]);
                    r--;
                }
            }
            
            result+=val;
            count++;
            
            if(count==k) return result;
        }
        
        while(pqLeft.Count>0)
        {
            int val = pqLeft.Dequeue();
            result+=val;
            count++;
            
            if(count==k) return result;
        }
        
        while(pqRight.Count>0)
        {
            int val = pqRight.Dequeue();
            result+=val;
            count++;
            
            if(count==k) return result;
        }
        
        return result;
    }
}