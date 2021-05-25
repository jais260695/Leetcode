public class MajorityChecker {
    public class Pair
    {
        public int val;
        public int count;
        public Pair(int val, int count)
        {
            this.val = val;
            this.count = count;
        }
    }

    Pair[] segmentTree;
    int[] arr;
    int n = 0;
    
    public Pair Merge(Pair l, Pair r)
    {
        if(l.val==r.val)
        {
            return new Pair(l.val,l.count+r.count);
        }
        else if(l.count>r.count)
        {
            return new Pair(l.val,l.count-r.count);
        }
        return new Pair(r.val,r.count-l.count);
    }
    
    public void CreateSegmentTree(int root, int left, int right)
    {
        if(left>right) return;
        
        if(left==right)
        {
            segmentTree[root]=new Pair(arr[left],1); 
            return;
        }
        
        int mid = left + (right-left)/2;
        
        int leftChild = 2*root+1;
        int rightChild = 2*root+2;
        
        CreateSegmentTree(leftChild,left,mid);
        CreateSegmentTree(rightChild,mid+1,right);
        
        segmentTree[root]= Merge(segmentTree[leftChild], segmentTree[rightChild]);
        
    }
    
    public Pair QuerySegmentTree(int root, int left, int right, int sq, int eq)
    {
        if(left>eq || right<sq) return new Pair(0,0);
        
        if(left>=sq && right<=eq)
        {
            return segmentTree[root];
        }
        
        int mid = left + (right-left)/2;
        
        int leftChild = 2*root+1;
        int rightChild = 2*root+2;
        
        Pair leftResult = QuerySegmentTree(leftChild,left,mid,sq,eq);
        Pair rightResult = QuerySegmentTree(rightChild,mid+1,right,sq,eq);
        
        
        Pair result= Merge(leftResult, rightResult);
        return result;
    }
    
    public MajorityChecker(int[] arr) {
        this.arr = arr;
        n = arr.Count();
        int x = (int) (Math.Ceiling(Math.Log(n) / Math.Log(2)));
        int max_size = 2 * (int) Math.Pow(2, x) - 1;
        segmentTree = new Pair[max_size];
     
        CreateSegmentTree(0,0,n-1);
    }
    
    public int Query(int left, int right, int threshold) {
        Pair result =  QuerySegmentTree(0,0,n-1,left,right);
        
        int count =0;
        for(int i=left;i<=right;i++)
        {
            if(arr[i]==result.val)
            {
                count++;
            }
        }
        
        if(count>=threshold) return result.val;
        
        return -1;
    }
}

/**
 * Your MajorityChecker object will be instantiated and called as such:
 * MajorityChecker obj = new MajorityChecker(arr);
 * int param_1 = obj.Query(left,right,threshold);
 */