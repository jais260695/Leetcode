public class Solution {
    public IList<int> MaxScoreIndices(int[] nums) {
        int n = nums.Count();

        int totalOnes = 0;

        for(int i=0;i<n;i++)
        {
            if(nums[i]==1) totalOnes++;
        }

        int countOnes = 0;
        int countZeroes = 0;
        List<int> result = new List<int>();
        int maximumScore = 0;
        for(int i=0;i<=n;i++)
        {
            int score = countZeroes + (totalOnes-countOnes);            
            if(maximumScore<=score)
            {                
                if(maximumScore<score)
                {
                    result.Clear();
                }
                result.Add(i);
                maximumScore=score;
            }
            if(i==n) break;
            if(nums[i]==1) countOnes++;
            else countZeroes++;
        }

        return result.ToList<int>();
    }
}