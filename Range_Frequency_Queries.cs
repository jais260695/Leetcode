public class RangeFreqQuery {

    Dictionary<int,int>[] segmentTree;
    int n;
    
    public void ConstructSegmentTree(int[] arr, int index, int si, int se)
    {
        if(si==se)
        {
            segmentTree[index] = new Dictionary<int,int>();
            segmentTree[index].Add(arr[si],1);
            return;
        }
        int mid = si + (se-si)/2;
        int left = 2*index+1;
        int right = 2*index+2;
        ConstructSegmentTree(arr,left,si,mid);
        ConstructSegmentTree(arr,right,mid+1,se);
        segmentTree[index] = new Dictionary<int,int>();
        
        foreach(KeyValuePair<int,int> kvp in segmentTree[left])
        {
            if(!segmentTree[index].ContainsKey(kvp.Key))
            {
                segmentTree[index].Add(kvp.Key,0);
            }
            segmentTree[index][kvp.Key]+=kvp.Value;
        }
        
        foreach(KeyValuePair<int,int> kvp in segmentTree[right])
        {
            if(!segmentTree[index].ContainsKey(kvp.Key))
            {
                segmentTree[index].Add(kvp.Key,0);
            }
            segmentTree[index][kvp.Key]+=kvp.Value;
        }
        
        return;
    }
    
    public int SearchSegmentTree(int index,int si, int se, int l, int r, int value)
    {
        if(si>r || se<l) 
            return 0;
        
        if(si>=l && se<=r)
        {
            if(segmentTree[index].ContainsKey(value))
            {
                return segmentTree[index][value];
            }
            return 0;
        }
        
        int mid = si + (se-si)/2;
        return SearchSegmentTree(2*index+1,si,mid,l,r,value) + SearchSegmentTree(2*index+2,mid+1,se,l,r,value);
    }
    
    public RangeFreqQuery(int[] arr) {
        n = arr.Count();
        int x = (int) (Math.Ceiling(Math.Log(n) / Math.Log(2)));
        int N = (int) Math.Pow(2, x+1)-1;
        segmentTree = new Dictionary<int,int>[N];
        ConstructSegmentTree(arr,0,0,n-1);
    }
    
    public int Query(int left, int right, int value) {
        return SearchSegmentTree(0,0,n-1,left,right,value);
    }
}

/**
 * Your RangeFreqQuery object will be instantiated and called as such:
 * RangeFreqQuery obj = new RangeFreqQuery(arr);
 * int param_1 = obj.Query(left,right,value);
 */