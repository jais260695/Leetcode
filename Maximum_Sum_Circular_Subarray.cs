public class Solution {
    public int MaxSubarraySumCircular(int[] nums) {
        int n = nums.Count();
        int maxTillHere = int.MinValue;
        int maxSoFar = int.MinValue;
        int minTillHere = int.MaxValue;;
        int minSoFar = int.MaxValue;
        int total = 0;
        for(int i=0;i<n;i++)
        {
            total+=nums[i];
            if(maxTillHere<0)
            {
                maxTillHere = 0;
            }
            maxTillHere+=nums[i];
            maxSoFar = Math.Max(maxTillHere,maxSoFar);
            
            if(minTillHere>0)
            {
                minTillHere = 0;
            }
            minTillHere+=nums[i];
            minSoFar = Math.Min(minTillHere,minSoFar);
        }
        minSoFar = minSoFar==total?0:minSoFar;
        return Math.Max(maxSoFar,total-minSoFar);
    }
}