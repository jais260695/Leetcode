public class Solution {
    public int EatenApples(int[] apples, int[] days) {
        int n = apples.Count();
        PriorityQueue<int,int> pq = new PriorityQueue<int,int>();
        int result = 0;
        for(int i=0;i<n || pq.Count>0;i++)
        {
            if(i<n)
            {
                pq.Enqueue(apples[i],i+days[i]);
            }

            while(pq.Count>0 && pq.TryDequeue(out int apple, out int expiryDay))
            {
                if(apple>0 && expiryDay>i)
                {
                    result++;
                    pq.Enqueue(apple-1,expiryDay);
                    break;
                }
            }

        }
        return result;
    }
}