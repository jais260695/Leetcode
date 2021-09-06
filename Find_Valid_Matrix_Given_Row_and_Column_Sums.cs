public class Solution {
    public class Pair
    {
        public int val;
        public char spec;
        public int pos;
        public Pair(int v, char s,int p)
        {
            val = v;
            spec = s;
            pos = p;
        }
    }
    List<Pair> minHeap = new List<Pair>();
    int heapSize = 0;
    public void Swap(int i, int j)
    {
        Pair t = minHeap[i];
        minHeap[i] = minHeap[j];
        minHeap[j] = t;
    }
    public void InsertMin(Pair p)
    {
        minHeap.Add(p);
        int i = heapSize;
        heapSize++;
        int parent = (i-1)/2;
        while(i!=0 && minHeap[i].val<minHeap[parent].val)
        {
            Swap(i,parent);
            i = parent;
            parent = (i-1)/2;
        }
        return;
    }
    public void MinHeapify(int i)
    {
        int smallest = i;
        int left = 2*i+1;
        int right = 2*i+2;
        if(left<heapSize && minHeap[left].val<minHeap[smallest].val)
        {
            smallest = left;
        }
        if(right<heapSize && minHeap[right].val<minHeap[smallest].val)
        {
            smallest = right;
        }
        if(i!=smallest)
        {
            Swap(i,smallest);
            MinHeapify(smallest);
        }
    }
    public Pair ExtractMin()
    {
        if(heapSize==0) return null;
        heapSize--;
        Pair min = minHeap[0];
        minHeap[0] = minHeap[heapSize];
        minHeap.RemoveAt(heapSize);
        MinHeapify(0);
        return min;
    }
    public void UpdateMin(int val, int pos, int spec)
    {
        int i = minHeap.FindIndex(p => p.pos == pos && p.spec == spec);
        minHeap[i].val = val;
        int parent = (i-1)/2;
        while(i!=0 && minHeap[i].val<minHeap[parent].val)
        {
            Swap(i,parent);
            i = parent;
            parent = (i-1)/2;
        }
        return;
    }
    public int[][] RestoreMatrix(int[] rowSum, int[] colSum) {
        int R = rowSum.Count();
        int C = colSum.Count();
        
        int[][] result = new int[R][];
        
        for(int i=0;i<R;i++)
        {
            result[i] = new int[C];
            InsertMin(new Pair(rowSum[i],'R',i));    
        }
        
        for(int i=0;i<C;i++)
        {
            InsertMin(new Pair(colSum[i],'C',i));
        }
        while(heapSize>1)
        {
            Pair p = ExtractMin();
            int val = p.val;
            char spec = p.spec;
            int pos = p.pos;
            if(val==0) continue;
            if(spec=='R')
            {
                for(int i=0;i<C;i++)
                {
                    if(colSum[i]>=val)
                    {
                        result[pos][i] = val;
                        rowSum[pos]-=val;
                        UpdateMin(colSum[i]-val,i,'C');
                        colSum[i]-=val;
                        break;
                    }
                }
            }
            else if(spec=='C')
            {
                for(int i=0;i<R;i++)
                {
                    if(rowSum[i]>=val)
                    {
                        result[i][pos] = val;
                        colSum[pos]-=val;
                        UpdateMin(rowSum[i]-val,i,'R');
                        rowSum[i]-=val;
                        break;
                    }
                }
            }
        }
        
        return result;
        
    }
}