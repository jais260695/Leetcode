public class Solution {
    public IList<IList<int>> Subsets(int[] nums) {
        int n = nums.Count();
        int val = (int)Math.Pow(2,n);
        List<List<int>> result = new List<List<int>>();
        for(int i=0;i<val;i++)
        {
            int temp = 1;
            List<int> res = new List<int>();
            for(int j=0;j<n;j++)
            {
                if((i&temp) >  0)
                {
                    res.Add(nums[j]);
                }
                temp<<=1;
            }
            result.Add(res);
        }
        return result.ToList<IList<int>>();
    }
}