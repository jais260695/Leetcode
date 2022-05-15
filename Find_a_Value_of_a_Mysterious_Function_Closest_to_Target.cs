public class Solution {
    int[] segmentTree;
    
    public int ConstructSegmentTree(int[] arr, int l, int r, int i)
    {
        if(l==r)
        {
            return segmentTree[i] = arr[l];
        }
        
        int mid = l + (r-l)/2;
        
        return segmentTree[i] = ConstructSegmentTree(arr, l, mid, 2*i+1) & ConstructSegmentTree(arr, mid+1, r, 2*i+2);
    }
    
    public int GetRangeAND(int ss, int se, int l, int r, int i)
    {
        if(ss>=l && se<=r)
        {
            return segmentTree[i];
        }
        else if(ss>r || se<l)
        {
            return (1<<30) -1;
        }
        
        int mid = ss + (se-ss)/2;
        
        return GetRangeAND(ss,mid,l,r,2*i+1) & GetRangeAND(mid+1,se,l,r,2*i+2);
    }
    
    public int BinarySearch(int l , int r, int target)
    {
        int i = l;
        int j = r;
        while(l<=r)
        {
            int mid = l+ (r-l)/2;
            int t = GetRangeAND(0,j,i,mid,0);
            if(t>=target)
            {
                l = mid+1;
            }
            else
            {
                r = mid-1;
            }
        }
        
        return r;
    }

    
    public int ClosestToTarget(int[] arr, int target) {
        int n = arr.Count();
        
        //Calculate the segment tree length
        int x = (int) (Math.Ceiling(Math.Log(n) / Math.Log(2)));
        int N = 2*(int)Math.Pow(2,x) - 1;
        
        segmentTree = new int[N];
        
        //Construct segment tree of range AND to efficiently fetch any range AND operations 
        ConstructSegmentTree(arr, 0, n-1, 0);
        
        int min = int.MaxValue;
        
        for(int i=0;i<n;i++)
        {
            //As AND operartion will casuse any range in non increasing  order, so we can use binary search
            //Proof: [2,6,8] 2=0010, 6 = 0110 , 8 = 1000 . Now 2&6 = 0010 & 0110 =  0010 = 2, and  2 & 8 = 0010 & 1000 = 0
            
            // Minimum of differnce of target to just greater and just smaller value will give the required result
            int p = BinarySearch(i,n-1,target);
            int justGreater = GetRangeAND(0,n-1,i,p,0);
            min = Math.Min(min,Math.Abs(target-justGreater));
            if(p<n-1)
            {
                int justSmaller = GetRangeAND(0,n-1,i,p+1,0);
                min = Math.Min(min,Math.Abs(target-justSmaller));
            }
        }
        
        return min;
    }
}