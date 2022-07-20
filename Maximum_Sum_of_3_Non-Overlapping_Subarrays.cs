public class Solution {
    int[] prefixSum;
    int K;
    int n;
    int[,] dp; 
    Dictionary<string,List<int>> dict = new Dictionary<string,List<int>>();
    int Solve(int index, int limit)
    {
        string key = index+"|"+limit;
        
        if(limit==3 || index+K>n) 
        {
            if(!dict.ContainsKey(key))
                dict.Add(key,new List<int>());
            return 0;
        }
        
        if(dp[limit,index]!=-1) return dp[limit,index];
        
        dict.Add(key,new List<int>());
        
        int resultWhenIncluded = prefixSum[index+K] - prefixSum[index] + Solve(index+K,limit+1);
        int resultWhenNotIncluded = Solve(index+1,limit);
        
        if(resultWhenIncluded>=resultWhenNotIncluded)
        {
            //Add cuurent index in current hashtable/dictionary
            dict[key].Add(index);
            
            //Add result from hashtable of subproblem solved, after including current index
            string keyTemp = (index+K)+"|"+(limit+1);
            foreach(int v in dict[keyTemp])
            {
                dict[key].Add(v);
            }
            
            dp[limit,index] = resultWhenIncluded;
        }
        else
        {
            //Add result from hashtable of subproblem after excluding current index
            string keyTemp = (index+1)+"|"+limit;
            foreach(int v in dict[keyTemp])
            {
                dict[key].Add(v);
            }
            
            dp[limit,index] = resultWhenNotIncluded;
        }
        
        return dp[limit,index];
    }
    public int[] MaxSumOfThreeSubarrays(int[] nums, int k) {
        K=k;
        n = nums.Count();
        prefixSum = new int[n+1];
        dp = new int[3,n];
        for(int i=0;i<3;i++)
        {
            for(int j=0;j<n;j++)
            {
                dp[i,j] = -1;
            }
        }
        for(int i=1;i<=n;i++)
        {
            prefixSum[i] = nums[i-1] + prefixSum[i-1];
        }
        
        Solve(0,0);
        string key = 0+"|"+0;
        return dict[key].ToArray();
    }
}