public class Solution {
    public class TempComparer : IComparer<int>
    {
        public int Compare(int a, int b)
        {
            return b-a;
        }
    }
    public int StoneGameVI(int[] aliceValues, int[] bobValues) {
        int n = aliceValues.Count();
        int sum = 0;
        
        PriorityQueue<int[],int> pq = new PriorityQueue<int[],int>(new TempComparer());
        
        for(int i=0;i<n;i++)
        {
            pq.Enqueue(new int[2]{aliceValues[i],bobValues[i]},aliceValues[i]+bobValues[i]);
        }
        
        int k = 0;
        while(pq.TryDequeue(out int[] t, out int priority))
        {
            if(k%2==0)
            {
                sum+=t[0];
            }
            else
            {
                sum-=t[1];
            }
            k++;
        }
        
        return sum>0 ? 1 : (sum<0 ? -1 : 0);
    }
}