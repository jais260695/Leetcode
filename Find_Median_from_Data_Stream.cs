public class MedianFinder {
    List<int> maxHeap = new List<int>();
    List<int> minHeap = new List<int>();
    double median = 0;
    
     int Parent(int i)
    {
        return (i-1)/2;
    }

     void InsertMinKey(List<int> dist,int p)
    {
        int i=dist.Count;
        dist.Add(p);
        int parent = Parent(i);
        while(i!=0 && dist[parent]>dist[i])
        {   
            int temp = dist[i];
            dist[i]=dist[parent];
            dist[parent]=temp;
            i=Parent(i);
            parent=Parent(i);
        }
    }

     void MinHeapify(List<int> dist,int i)
    {
        int smallest = i;
        int left = 2*i+1;
        int right = 2*i+2;
        if(left<dist.Count && dist[left]<dist[smallest])
        {
            smallest =left;
        }
        if(right<dist.Count && dist[right]<dist[smallest])
        {
            smallest=right;
        }
        if(smallest!=i)
        {
            int temp = dist[i];
            dist[i]=dist[smallest];
            dist[smallest]=temp;
            MinHeapify(dist, smallest);
        }
    }

     int ExtractMin(List<int> dist)
    { 
        if(dist.Count()==1)
        {
            int minimum = dist[0];
            dist.RemoveAt(0);
            return minimum;
        }
        int min=dist[0];
        dist[0]=dist[dist.Count-1];
        dist.RemoveAt(dist.Count-1);
        MinHeapify(dist,0); 
        return min;
    }

     void InsertMaxKey(List<int> dist,int p)
    {
        int i=dist.Count;
        dist.Add(p);
        int parent = Parent(i);
        while(i!=0 && dist[parent]<dist[i])
        {   
            int temp = dist[i];
            dist[i]=dist[parent];
            dist[parent]=temp;
            i=Parent(i);
            parent=Parent(i);
        }
    }

     void MaxHeapify(List<int> dist,int i)
    {
        int largest = i;
        int left = 2*i+1;
        int right = 2*i+2;
        if(left<dist.Count && dist[left]>dist[largest])
        {
            largest =left;
        }
        if(right<dist.Count && dist[right]>dist[largest])
        {
            largest=right;
        }
        if(largest!=i)
        {
            int temp = dist[i];
            dist[i]=dist[largest];
            dist[largest]=temp;
            MaxHeapify(dist, largest);
        }
    }

     int ExtractMax(List<int> dist)
    { 
        if(dist.Count()==1)
        {
            int maximum = dist[0];
            dist.RemoveAt(0);
            return maximum;
        }
        int max=dist[0];
        dist[0]=dist[dist.Count-1];
        dist.RemoveAt(dist.Count-1);
        MaxHeapify(dist,0); 
        return max;
    }
    
    

    /** initialize your data structure here. */
    public MedianFinder() {
        
    }
    
    public void AddNum(int val) {
        int maxHeapLen = maxHeap.Count;
        int minHeapLen = minHeap.Count;
        if(maxHeapLen==minHeapLen)
        {
            if(val<median)
            {
                InsertMaxKey(maxHeap,val);
                median = (double)maxHeap[0];
            }
            else
            {
                InsertMinKey(minHeap,val);
                median = (double)minHeap[0];
            }
        }
        else if(maxHeapLen>minHeapLen)
        {
            if(val<median)
            {
                int maxV = ExtractMax(maxHeap);
                InsertMinKey(minHeap,maxV);
                InsertMaxKey(maxHeap,val);
            }
            else
            {
                InsertMinKey(minHeap,val);
            }
            median = (double)(maxHeap[0] + minHeap[0])/2;
        }
        else
        {
            if(val<median)
            {
                InsertMaxKey(maxHeap,val);
            }
            else
            {
                int minV = ExtractMin(minHeap);
                InsertMaxKey(maxHeap,minV);
                InsertMinKey(minHeap,val);
            }
            median = (double)(maxHeap[0] + minHeap[0])/2;
        }
    }
    
    public double FindMedian() {
        return median;
    }
}

/**
 * Your MedianFinder object will be instantiated and called as such:
 * MedianFinder obj = new MedianFinder();
 * obj.AddNum(num);
 * double param_2 = obj.FindMedian();
 */