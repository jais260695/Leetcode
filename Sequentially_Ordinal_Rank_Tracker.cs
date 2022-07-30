public class SORTracker {
    
    public class Pair
    {
        public string Name;
        public int Score;
        public Pair(string name, int score)
        {
            Name = name;
            Score = score;
        }
    }
    
    int maxHeapSize;
    int minHeapSize;
    int k;
    
    List<Pair> minHeap;
    List<Pair> maxHeap;
    
    public bool IsLexicographicallySmaller(string str1, string str2)
    {
        int n1 = str1.Length;
        int n2 = str2.Length;
        
        int i=0;
        int j=0;
        
        while(i<n1 && j<n2)
        {
            if(str1[i]<str2[j])
            {
                return true;
            }
            else if(str1[i]>str2[j])
            {
                return false;
            }
            
            i++;
            j++;
        }
        
        return i==n1;
    }
    
    public void MinHeapify(int index)
    {
        int left = 2*index+1;
        int right = 2*index+2;
        int smallest = index;
        
        if
        (
            left<minHeapSize && 
            (
                minHeap[left].Score < minHeap[index].Score || 
                ( 
                    minHeap[left].Score == minHeap[index].Score && 
                    !IsLexicographicallySmaller(minHeap[left].Name, minHeap[index].Name)  
                )
            )
        )
        {
            smallest = left;
        }
        
        if
        (
            right<minHeapSize && 
            (
                minHeap[right].Score < minHeap[smallest].Score || 
                ( 
                    minHeap[right].Score == minHeap[smallest].Score && 
                    !IsLexicographicallySmaller(minHeap[right].Name, minHeap[smallest].Name)  
                )
            )
        )
        {
            smallest = right;
        }
        
        if(smallest != index)
        {
            Pair temp = minHeap[index];
            minHeap[index] = minHeap[smallest];
            minHeap[smallest] = temp;
            
            MinHeapify(smallest);
        }
    }
    
    public Pair ExtractMin()
    {
        if(minHeapSize==0) return null;
        
        Pair min = minHeap[0];
        
        minHeap[0] = minHeap[minHeapSize-1];
        minHeapSize--;
        minHeap.RemoveAt(minHeapSize);
        MinHeapify(0);
        
        return min;
    }
    
    public void InsertMin(Pair newPair)
    {
        minHeap.Add(newPair);
        minHeapSize++;
        
        int i = minHeapSize-1;
        int parent = (i-1)/2;
        
        while
        (
            i!=0 &&
            (
                minHeap[i].Score < minHeap[parent].Score || 
                ( 
                    minHeap[i].Score == minHeap[parent].Score && 
                    !IsLexicographicallySmaller(minHeap[i].Name, minHeap[parent].Name)  
                )
            )
        )
        {
            Pair temp = minHeap[i];
            minHeap[i] = minHeap[parent];
            minHeap[parent] = temp;
            
            i = parent;
            parent = (i-1)/2;
        }
    }
    
    public void MaxHeapify(int index)
    {
        int left = 2*index+1;
        int right = 2*index+2;
        int smallest = index;
        
        if
        (
            left<maxHeapSize && 
            (
                maxHeap[left].Score > maxHeap[index].Score || 
                ( 
                    maxHeap[left].Score == maxHeap[index].Score && 
                    IsLexicographicallySmaller(maxHeap[left].Name, maxHeap[index].Name)  
                )
            )
        )
        {
            smallest = left;
        }
        
        if
        (
            right<maxHeapSize && 
            (
                maxHeap[right].Score > maxHeap[smallest].Score || 
                ( 
                    maxHeap[right].Score == maxHeap[smallest].Score && 
                    IsLexicographicallySmaller(maxHeap[right].Name, maxHeap[smallest].Name)  
                )
            )
        )
        {
            smallest = right;
        }
        
        if(smallest != index)
        {
            Pair temp = maxHeap[index];
            maxHeap[index] = maxHeap[smallest];
            maxHeap[smallest] = temp;
            
            MaxHeapify(smallest);
        }
    }
    
    public Pair ExtractMax()
    {
        if(maxHeapSize==0) return null;
        
        Pair max = maxHeap[0];
        
        maxHeap[0] = maxHeap[maxHeapSize-1];
        maxHeapSize--;
        maxHeap.RemoveAt(maxHeapSize);
        MaxHeapify(0);
        
        return max;
    }
    
    public void InsertMax(Pair newPair)
    {
        maxHeap.Add(newPair);
        maxHeapSize++;
        
        int i = maxHeapSize-1;
        int parent = (i-1)/2;
        
        while
        (
            i!=0 &&
            (
                maxHeap[i].Score > maxHeap[parent].Score || 
                ( 
                    maxHeap[i].Score == maxHeap[parent].Score && 
                    IsLexicographicallySmaller(maxHeap[i].Name, maxHeap[parent].Name)  
                )
            )
        )
        {
            Pair temp = maxHeap[i];
            maxHeap[i] = maxHeap[parent];
            maxHeap[parent] = temp;
            
            i = parent;
            parent = (i-1)/2;
        }
    }
    

    public SORTracker() {
        maxHeapSize = 0;
        minHeapSize = 0;
        k = 1;
        minHeap = new List<Pair>();
        maxHeap = new List<Pair>();
    }
    
    public void Add(string name, int score) {
        if(minHeapSize < k || score > minHeap[0].Score || (score == minHeap[0].Score && IsLexicographicallySmaller(name,minHeap[0].Name)))
        {
            if(minHeapSize==k)
            {
                Pair min = ExtractMin();
                
                if(min!=null)
                {
                    InsertMax(min);
                }
            }
            
            InsertMin(new Pair(name,score));
        }
        else
        {
            InsertMax(new Pair(name,score));
        }
    }
    
    public string Get() {
        string result = minHeap[0].Name;
        k++;
        Pair max = ExtractMax();
        
        if(max!=null)
        {
            InsertMin(max);
        }
        
        return result;
    }
}

/**
 * Your SORTracker object will be instantiated and called as such:
 * SORTracker obj = new SORTracker();
 * obj.Add(name,score);
 * string param_2 = obj.Get();
 */