public class Solution {
    public List<int> maxHeap;
    public int heapSize;
    public Solution()
    {
        maxHeap = new List<int>();
        heapSize = 0;
    }
    public void Swap(int i, int j)
    {
        int temp = maxHeap[i];
        maxHeap[i] = maxHeap[j];
        maxHeap[j] = temp;
    }
    public void MaxHeapify(int i)
    {
        int largest = i;
        int left = 2*i+1;
        int right = 2*i+1;
        if(left<heapSize && maxHeap[left]>maxHeap[largest])
        {
            largest = left;
        }
        if(right<heapSize && maxHeap[right]>maxHeap[largest])
        {
            largest = right;
        }
        if(i!=largest)
        {
            Swap(i,largest);
            MaxHeapify(largest);
        }
    }
    public int ExtractMax()
    {
        int max = maxHeap[0];
        maxHeap[0] = maxHeap[heapSize-1];
        maxHeap.RemoveAt(heapSize-1);
        heapSize--;
        MaxHeapify(0);
        return max;
    }
    public void InsertKey(int val)
    {
        maxHeap.Add(val);
        heapSize++;
        int i=heapSize-1;
        int parent = (i-1)/2;
        while(i!=0 && maxHeap[parent]<maxHeap[i])
        {
            Swap(i,parent);
            i = parent;
            parent = (i-1)/2;
        }
    }
    public int MaximumScore(int a, int b, int c) {
        InsertKey(a);
        InsertKey(b);
        InsertKey(c);
        int count = 0;
        while(heapSize>1)
        {
            int x = ExtractMax();
            int y = ExtractMax();
            x--;
            y--;
            count++;
            if(x>0)
            {
                InsertKey(x);
            }
            if(y>0)
            {
                InsertKey(y);
            }
        }
        return count;
    }
}