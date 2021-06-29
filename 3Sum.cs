public class Solution {
    public IList<IList<int>> ThreeSum(int[] nums) {
        int n = nums.Count();
        List<List<int>> result = new List<List<int>>();
        Array.Sort(nums);        
        for(int i=0;i<n;i++)
        {
            if(i>0 &&  nums[i]==nums[i-1]) continue;
            int target = -nums[i];
            int l = i+1;
            int h = n-1;
            while(l<h)
            {
                int sum = nums[l]+nums[h];
                if(sum==target)
                {
                    result.Add(new List<int>{nums[i],nums[l],nums[h]});
                    l++;
                    h--;
                    while(l<h && nums[l]==nums[l-1]) l++;
                    while(h>l && nums[h]==nums[h+1]) h--;
                }
                else if(sum>target)
                {
                    h--;
                }
                else
                {
                    l++;
                }
            }
        }
        return result.ToList<IList<int>>();
    }
}