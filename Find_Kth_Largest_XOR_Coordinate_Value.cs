public class Solution {
    List<int> maxHeap = new List<int>();
    int heapSize = 0;
    public void Swap(int i, int j)
    {
        int temp = maxHeap[i];
        maxHeap[i] = maxHeap[j];
        maxHeap[j] = temp;
    }
    public void MaxHeapify(int i)
    {
        int largest = i;
        int leftChild = 2*i+1;
        int rightChild = 2*i+2;
        if(leftChild<heapSize && maxHeap[leftChild]>maxHeap[largest])
        {
            largest = leftChild;
        }
        if(rightChild<heapSize && maxHeap[rightChild]>maxHeap[largest])
        {
            largest = rightChild;
        }
        if(largest!=i)
        {
            Swap(i,largest);
            MaxHeapify(largest);
        }
    }
    public void InsertMax(int key)
    {
        maxHeap.Add(key);
        int i = heapSize;
        heapSize++;
        int parent = (i - 1)/2;
        while(i>0 && maxHeap[parent]<maxHeap[i])
        {
            Swap(i,parent);
            i = parent;
            parent = (i-1)/2;           
        }
    }
    public int ExtractMax()
    {
        heapSize--;
        int max = maxHeap[0];
        Swap(0,heapSize);
        maxHeap.RemoveAt(heapSize);
        MaxHeapify(0);      
        return max;
    }
    public int KthLargestValue(int[][] matrix, int k) {
        int R = matrix.Count();
        int C = matrix[0].Count();
        
        InsertMax(matrix[0][0]);
        
        for(int col = 1;col<C;col++)
        {
            matrix[0][col] ^= matrix[0][col-1];
            InsertMax(matrix[0][col]);
        }
        
        for(int row = 1;row<R;row++)
        {
            matrix[row][0] ^= matrix[row-1][0];
            InsertMax(matrix[row][0]);
        }
        
        for(int row = 1;row<R;row++)
        {
            for(int col=1;col<C;col++)
            {
                matrix[row][col] ^= (matrix[row-1][col]^matrix[row][col-1]^matrix[row-1][col-1]);
                InsertMax(matrix[row][col]);
            }
        }
        
        int result = 0;
        
        for(int i = 0;i<k;i++)
        {
            result = ExtractMax();
        }
        
        return result;
    }
}