public class Solution {
    int[] segmentTree;
    int N;
    public void ConstructSegmentTree(int[] arr, int ss, int se, int index)
    {
        if(ss==se)
        {
            segmentTree[index] = arr[ss];
            return;
        }
        
        int mid = ss + (se-ss)/2;   
        
        int left = 2*index+1;
        ConstructSegmentTree(arr, ss, mid,left);
        
        
        int right = 2*index+2;
        ConstructSegmentTree(arr, mid+1, se,right); 
        
        segmentTree[index] = Math.Max(segmentTree[left],segmentTree[right]);
        return;
    }
    
    public int GetMaximumFromRange(int ss, int se, int index, int l, int r)
    {
        if(ss>r || se<l)
        {
            return int.MinValue;
        }
        
        if(ss>=l && se<=r)
        {
            return segmentTree[index];
        }
        
        
        int mid = ss + (se-ss)/2;   
        
        int left = 2*index+1;
        int right = 2*index+2;
        
        return Math.Max(GetMaximumFromRange(ss,mid,left,l,r),GetMaximumFromRange(mid+1,se,right,l,r));
    }
    
    
    public int MctFromLeafValues(int[] arr) {
        int n = arr.Count();
        
        int x = (int)Math.Ceiling(Math.Log(n)/Math.Log(2));
        N = 2*(int)Math.Pow(2,x) - 1;
        segmentTree = new int[N];
        ConstructSegmentTree(arr, 0, n-1,0);
        
        int[,] dp = new int[n,n];
        
        for(int t=1;t<n;t++)
        {
            for(int i=0,j=t;j<n;i++,j++)
            {
                dp[i,j] = int.MaxValue;
                for(int k = i; k<j;k++)
                {
                    dp[i,j] = Math.Min(dp[i,j],
                                        dp[i,k]+
                                        dp[k+1,j]+
                                        (GetMaximumFromRange(0,n-1,0,i,k)*GetMaximumFromRange(0,n-1,0,k+1,j))
                                    );
                    
                }
                
            }
        }
        return dp[0,n-1];
    }
}