public class Solution {
    public int heapSize;
    public void MaxHeapify(int[] stones, int i)
    {
        int largest = i;
        int left = 2*i+1;
        int right = 2*i+2;
        if(left<heapSize && stones[largest]<stones[left])
        {
            largest = left;
        }
        if(right<heapSize && stones[largest]<stones[right])
        {
            largest = right;
        }
        if(largest!=i)
        {
            int temp = stones[i];
            stones[i] = stones[largest];
            stones[largest] = temp;
            MaxHeapify(stones, largest);
        }
    }
    public int ExtractMax(int[] stones)
    {
        int max = stones[0];
        stones[0] = stones[heapSize-1];
        stones[heapSize-1] = max;
        heapSize--;
        MaxHeapify(stones,0);
        return max;
    }
    public void InsertValue(int[] stones, int val)
    {
        heapSize++;
        stones[heapSize-1] = val;
        int i = heapSize-1;
        int parent = (i-1)/2;
        while(i!=0 && stones[parent]<stones[i])
        {
            int temp = stones[parent];
            stones[parent] = stones[i];
            stones[i] = temp;
            i = parent;
            parent = (i-1)/2;
        }
        
    }
    public int LastStoneWeight(int[] stones) {
        heapSize = stones.Count();
        for(int i=(heapSize/2)-1;i>=0;i--)
        {
            MaxHeapify(stones,i);
        }
        while(heapSize>1)
        {
            int v1 = ExtractMax(stones);
            int v2 = ExtractMax(stones);
            if(v1!=v2)
            {
                InsertValue(stones,v1-v2);
            }
        }
        
        return heapSize==0?0:stones[0];
    }
}