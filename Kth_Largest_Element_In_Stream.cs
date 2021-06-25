public class KthLargest {
    List<int> minHeap = new List<int>();
    int HEAP_SIZE = 0;
    int CAPACITY = 0;
    
    void MinHeapify(int i)
    {
        int smallest = i;
        int left = 2*i+1;
        int right = 2*i+2;
        if(left < HEAP_SIZE && minHeap[left] < minHeap[smallest])
        {
            smallest = left;
        }
        if(right < HEAP_SIZE && minHeap[right] < minHeap[smallest])
        {
            smallest = right;
        }

        if(smallest != i)
        {
            int temp = minHeap[i];
            minHeap[i] = minHeap[smallest];
            minHeap[smallest] = temp;
            MinHeapify(smallest);
        }
    }
    
    void InsertKey(int key)
    {  
        if(HEAP_SIZE<CAPACITY)
        {
            minHeap.Add(key);
            int i = HEAP_SIZE;
            HEAP_SIZE++;
            int parent = (i-1)/2;
            while(i>0 && minHeap[parent]>minHeap[i])
            {
                int temp = minHeap[parent];
                minHeap[parent] = minHeap[i];
                minHeap[i] = temp;
                i = parent;
                parent = (i-1)/2;
            }
            return;
        }
        if(minHeap[0]<key)
        {
            minHeap[0] = key;
            MinHeapify(0);
        }

    }

    public KthLargest(int k, int[] nums) {
        CAPACITY = k;
        for(int i=0;i<nums.Count();i++)
        {
            InsertKey(nums[i]);
        }   
    }
    
    public int Add(int val) {
        InsertKey(val);
        return minHeap[0];
    }
}
