public class Solution {
    List<string> minHeap;
    int MAX_SIZE;
    int heapSize = 0;
    public bool IsGreater(string s1, string s2)
    {
        if(s1.Length==s2.Length)
        {
            int i=0;
            while(i<s1.Length)
            {
                if(s1[i]!=s2[i])
                {
                    return s1[i]>s2[i];
                }                
                i++;
            }
        }
        return s1.Length>s2.Length;
    }
    
    public void Swap(int i, int j)
    {
        string temp = minHeap[i];
        minHeap[i] = minHeap[j];
        minHeap[j] = temp;
    }
    
    public void MinHeapify(int i)
    {
        int left = 2*i+1;
        int right = 2*i+2;
        int smallest = i;
        if(left<heapSize && IsGreater(minHeap[smallest],minHeap[left]))
        {
            smallest = left;
        }
        if(right<heapSize && IsGreater(minHeap[smallest],minHeap[right]))
        {
            smallest = right;
        }
        
        if(i!=smallest)
        {
            Swap(i,smallest);
            MinHeapify(smallest);
        }
    }
    
    public string ExtractMin()
    {
        string min = minHeap[0];        
        minHeap[0] = minHeap[heapSize-1];
        minHeap.RemoveAt(heapSize-1);
        heapSize--;
        MinHeapify(0);
        return min;
    }
    
    public void InsertMin(string val)
    {
        if(heapSize==MAX_SIZE && IsGreater(val,minHeap[0]))
        {
            ExtractMin();
        }
        if(heapSize<MAX_SIZE)
        {
            minHeap.Add(val);
            heapSize++;
            
            int i = heapSize-1;
            int parent = (i-1)/2;
            while(i>0 && IsGreater(minHeap[parent],minHeap[i]))
            {
                Swap(parent,i);
                i = parent;
                parent = (i-1)/2;
            }
            return;
        }
        
        
    }
        
    public string KthLargestNumber(string[] nums, int k) {
        int n = nums.Count();
        minHeap = new List<string>();
        MAX_SIZE = k;
        
        for(int i=0;i<n;i++)
        {
            InsertMin(nums[i]);
        }
        
        return minHeap[0];
        
    }
}