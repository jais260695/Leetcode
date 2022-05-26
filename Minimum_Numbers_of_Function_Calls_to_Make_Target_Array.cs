public class Solution {
    public int MinOperations(int[] nums) {
        int n = nums.Count();
        
        int result = 0;
        bool allZeroes = true;
        for(int i=0;i<n;i++)
        {

            if(nums[i]%2!=0)
            {
                nums[i]--;
                result++;
            }    
            if(nums[i]!=0 && nums[i]%2==0)
            {
                allZeroes = false;
                nums[i]/=2;
            }
        }
        
        return  allZeroes ? result : result + 1 + MinOperations(nums);
    }
}