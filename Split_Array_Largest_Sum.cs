public class Solution {
    
    int[] prefixSum;
    int[,] dp;
    int arraySize;
    
    int FindMinSum(int currentIndex, int remainingSplits)
    {
        if(currentIndex==arraySize)
        {
            if(remainingSplits==0)
            {
                return 0;
            }
            return -1;
        }
        
        if(remainingSplits==0)
        {
            return -1;
        }
               
        if(dp[currentIndex,remainingSplits]!=-1)
        {
            return dp[currentIndex,remainingSplits];
        }        
        
        int result = int.MaxValue;
        
        for(int splitAt = currentIndex; splitAt < arraySize; splitAt++)
        {
            int sum = prefixSum[splitAt+1] - prefixSum[currentIndex];
            int temp = FindMinSum(splitAt+1,remainingSplits-1);
            
            if(temp==-1) continue;
            result = Math.Min(
                                result,
                                Math.Max
                                (
                                    sum,
                                    temp
                                )
                            );
        }
        
        return dp[currentIndex,remainingSplits] = result;
    }
    public int SplitArray(int[] nums, int m) {
        
        arraySize = nums.Count();
        prefixSum = new int[arraySize+1];
        dp = new int[arraySize,m+1];
        
        for(int i=1;i<=arraySize;i++)
        {
            prefixSum[i] = nums[i-1] + prefixSum[i-1];
        }
        
        for(int i=0;i<arraySize;i++)
        {
            for(int j=0;j<=m;j++)
            {
                dp[i,j] = -1;
            }
        }
        
        return FindMinSum(0,m);           
    }
}