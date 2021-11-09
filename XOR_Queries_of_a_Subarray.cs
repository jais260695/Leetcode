public class Solution {
    public int ConstructSegmentTree(int[] arr,int l,int r,int[] dp, int i)
    {
        if(l==r)
        {
            dp[i] = arr[l];
            return arr[l];
        }
        
        int mid = l+(r-l)/2;
        dp[i] = ConstructSegmentTree(arr,l,mid,dp,2*i+1) ^ ConstructSegmentTree(arr,mid+1,r,dp,2*i+2);
        return dp[i];
    }
    public int XORQueriesRes(int[] dp,int si, int sj, int l, int r, int i)
    {
        if(si<=l && sj>=r)
        {
            return dp[i];
        }
        
        if(sj<l || si>r)
        {
            return 0;
        }       
       
        int mid = l+(r-l)/2;
        return XORQueriesRes(dp,si,sj,l,mid,2*i+1)^XORQueriesRes(dp,si,sj,mid+1,r,2*i+2);
    }
    public int[] XorQueries(int[] arr, int[][] queries) {
        int n = arr.Count();
        int x = (int) (Math.Ceiling(Math.Log(n) / Math.Log(2))); 
        int max_size = 2 * (int) Math.Pow(2, x) - 1; 
        int[] dp = new int[max_size];
        
        ConstructSegmentTree(arr,0,n-1,dp,0);
        
        for(int i = 0;i<max_size;i++)
        {
            Console.Write(dp[i] +" ");
        }
        
        int m = queries.Count();
        int[]  result = new int[m];
        
        for(int i =0;i<m;i++)
        {
            result[i] = XORQueriesRes(dp,queries[i][0],queries[i][1],0,n-1,0);
        }
        return result;
    }
}