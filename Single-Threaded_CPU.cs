public class Solution {
    public class PQComparerEnqueue : IComparer<int[]>
    {
        public int Compare(int[] a, int [] b)
        {
            return a[0]!=b[0] ? a[0] - b[0] : a[1] - b[1];
        }
    }

    public class PQComparerProcess : IComparer<int[]>
    {
        public int Compare(int[] a, int [] b)
        {
            return a[1]!=b[1] ? a[1] - b[1] : a[0] - b[0];
        }
    }
    public int[] GetOrder(int[][] tasks) {
        int n = tasks.Count();

        PriorityQueue<int,int[]> pqEnqueueTime = new PriorityQueue<int,int[]>(new PQComparerEnqueue());

        for(int i=0;i<n;i++)
        {
            pqEnqueueTime.Enqueue(i,tasks[i]);
        }

        PriorityQueue<int,int[]> pqProcessTime = new PriorityQueue<int,int[]>(new PQComparerProcess());

        int[] result = new int[n];
        int currItr = 0;
        int processingCompletion = 0;
        while(currItr<n)
        {
            int index = pqEnqueueTime.Peek();
            processingCompletion = tasks[index][0];
            pqProcessTime.Enqueue(pqEnqueueTime.Peek(),new int[2]{pqEnqueueTime.Peek(), tasks[pqEnqueueTime.Peek()][1]});
            pqEnqueueTime.Dequeue();

            while(pqProcessTime.Count>0 && currItr<n)
            {
                index = pqProcessTime.Dequeue();
                result[currItr] = index;
                currItr++;
                processingCompletion+=tasks[index][1];
                while( pqEnqueueTime.Count>0 && tasks[pqEnqueueTime.Peek()][0]<=processingCompletion)
                {
                    pqProcessTime.Enqueue(pqEnqueueTime.Peek(),new int[2]{pqEnqueueTime.Peek(), tasks[pqEnqueueTime.Peek()][1]});
                    pqEnqueueTime.Dequeue();
                }
                
            }
        }
        return result;
    }
}