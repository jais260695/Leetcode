public class Solution {
    public int MinIncrementForUnique(int[] nums) {
        int n = nums.Count();
        Array.Sort(nums);
        int prev = nums[0];
        int res = 0;
        for(int i=1; i<n; i++){
            if(nums[i] <= prev){
                prev += nums[i] < prev ? 1 : prev - nums[i] + 1;
                res += prev - nums[i];
            }else{
                prev = nums[i];
            }
        }
        return res;
    }
}