public class Solution {
    Dictionary<int,int> dict = new Dictionary<int,int>();
    public int CombinationSum4(int[] nums, int target) {
        if(target<0) return 0;
        if(target==0) return 1;
        if(dict.ContainsKey(target)) return dict[target];
        int result = 0;
        for(int i=0;i<nums.Count();i++)
        {
            result+=CombinationSum4(nums,target-nums[i]);
        }
        dict.Add(target,result);
        return result;
    }
}