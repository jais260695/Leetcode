public class Solution {
    public int[] SumEvenAfterQueries(int[] nums, int[][] queries) {
        int n = nums.Count();
        int m = queries.Count();
        
        int[] result = new int[m];
        
        int sum = 0;
        for(int i=0;i<n;i++)
        {
            if(nums[i]%2==0)
            {
                sum+=nums[i];
            }
        }
        
        for(int i=0;i<m;i++)
        {
            int val = queries[i][0];
            int index = queries[i][1];
            if((nums[index]+val)%2==0)
            {
                if(nums[index]%2==0)
                {
                    sum+=val;
                }
                else
                {
                    sum+=(nums[index]+val);
                }
            }
            else
            {
                if(nums[index]%2==0)
                {
                    sum-=nums[index];
                }
            }
            
            nums[index] += val; 
            result[i] = sum;
        }
        
        return result;
    }
}