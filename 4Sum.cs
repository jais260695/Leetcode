public class Solution {
    public List<List<int>> ThreeSum(int[] nums, int s, int e, int goal) {
        int n = e-s+1;
        List<List<int>> result = new List<List<int>>();       
        for(int i=s;i<=e;i++)
        {
            if(i>s &&  nums[i]==nums[i-1]) continue;
            int target = goal-nums[i];
            int l = i+1;
            int h = e;
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
        return result;
    }
    public IList<IList<int>> FourSum(int[] nums, int target) {
        int n = nums.Count();
        List<List<int>> result = new List<List<int>>();
        Array.Sort(nums);
        for(int i=0;i<n-3;i++)
        {
            if(i>0 && nums[i]==nums[i-1]) continue;
            int newTarget = target-nums[i];
            List<List<int>> temp = ThreeSum(nums,i+1,n-1,newTarget);
            foreach(List<int> tsum in temp)
            {
                tsum.Add(nums[i]);
                result.Add(tsum);
            }   
        }
        
        return result.ToList<IList<int>>();
    }
}