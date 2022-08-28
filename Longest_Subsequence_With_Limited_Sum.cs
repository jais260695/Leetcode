public class Solution {
    //int[,]  dp;
    /*public int Solve(int index, int[] nums, int query, int level)
    {
        if(index==nums.Count())
        {
            return level;
        }
        
        //if(dp[index,query]!=0) return dp[index,query];
        
        int result = Solve(index+1,nums,query,level);
        if(nums[index]<=query)
        {
            result = Math.Max(result,Solve(index+1,nums,query-nums[index],level+1));
        }
        
        //dp[index,query] = result;
        return result;
    }*/
    public int[] AnswerQueries(int[] nums, int[] queries) {
        int n = nums.Count();
        int q = queries.Count();
        
        Array.Sort(nums);
        int[] prefixSum = new int[n+1];
        for(int i=1;i<=n;i++)
        {
            prefixSum[i] = prefixSum[i-1] + nums[i-1];
        }
       
        int[] result = new int[q];
        for(int i=0;i<q;i++)
        {
            int l = 1;
            int r = n;
            
            while(l<=r)
            {
                int mid = l+(r-l)/2;
                
                if(prefixSum[mid]>queries[i])
                {
                    r = mid -1;
                }
                else
                {
                    l = mid +1 ;
                }
            }
            
            result[i] = r;
        }
        
        return result;
    }
}