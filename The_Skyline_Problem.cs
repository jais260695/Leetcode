public class Solution {
    public class CoordState 
    {
        public int coord;
        public int height;
        public char state;
        public CoordState(int x, int h, char s)
        {
            coord = x;
            height = h;
            state = s;
        }
    }
    public List<int> priorityQueue = new List<int>();
    public void InsertKey(int key)
    {
        int size = priorityQueue.Count();
        priorityQueue.Add(key);
        int i = size;
        int parent = (i-1)/2;
        while(i>0 && priorityQueue[parent]<=priorityQueue[i])
        {
            int temp = priorityQueue[parent];
            priorityQueue[parent] = priorityQueue[i];
            priorityQueue[i] = temp;
            i = parent;
            parent = (i-1)/2;
        }
    }
    public int ExtractMax()
    {
        int size = priorityQueue.Count();
        int max = priorityQueue[0];
        priorityQueue[0] = priorityQueue[size-1];
        priorityQueue.RemoveAt(size-1);
        size--;
        MaxHeapify(0,size);
        return max;
    }
    
    public void RemoveKey(int key)
    {
        int i = priorityQueue.IndexOf(key);
        priorityQueue[i] = int.MaxValue;
        int parent = (i-1)/2;
        while(i>0 && priorityQueue[parent]<priorityQueue[i])
        {
            int temp = priorityQueue[parent];
            priorityQueue[parent] = priorityQueue[i];
            priorityQueue[i] = temp;
            i = parent;
            parent = (i-1)/2;
        }
        ExtractMax();
    }
    public void MaxHeapify(int i, int n)
    {
        int largest = i;
        int left = 2*i+1;
        int right = 2*i+2;
        if(left<n && priorityQueue[left]>=priorityQueue[largest])
        {
            largest = left;
        }
        if(right<n && priorityQueue[right]>=priorityQueue[largest])
        {
            largest = right;
        }
        if(largest!=i)
        {
            int temp = priorityQueue[i];
            priorityQueue[i] = priorityQueue[largest];
            priorityQueue[largest] = temp;
            MaxHeapify(largest,n);
        }
    }
    public IList<IList<int>> GetSkyline(int[][] buildings) {
        int n = buildings.Count();
        List<CoordState> listOfCoordinates = new List<CoordState>();
        for(int i=0;i<n;i++)
        {
            int left = buildings[i][0];
            int right = buildings[i][1];
            int height = buildings[i][2];
            listOfCoordinates.Add(new CoordState(left,height,'s'));
            listOfCoordinates.Add(new CoordState(right,height,'e'));
        }
        
        listOfCoordinates = listOfCoordinates.OrderBy(l=>l.coord).ThenByDescending(l => l.height).ThenByDescending(l=>l.state).ToList<CoordState>();

        InsertKey(0);
        int prevCoord = -1;
        List<List<int>> result = new List<List<int>>();
        foreach(CoordState cds in listOfCoordinates)
        {
            int coord = cds.coord;;
            int height = cds.height;
            char state = cds.state;
            
            if(state == 's')
            {

                
                if(priorityQueue[0]<height)
                {
                    result.Add(new List<int>{coord,height});
                }
                InsertKey(height);
                prevCoord = -1;
            }
            else
            {
                
                RemoveKey(height);
                if(height>priorityQueue[0])
                {
                    if(prevCoord==coord)
                        result.RemoveAt(result.Count()-1);
                    result.Add(new List<int>{coord,priorityQueue[0]});
                    prevCoord = coord;
                }
                else
                {
                    prevCoord = -1;
                }
                
            }
            
        }
        return result.ToList<IList<int>>();
    }
}