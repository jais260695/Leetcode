public class Solution {
    public IList<bool> CheckArithmeticSubarrays(int[] nums, int[] l, int[] r) {
        int n = nums.Count();
        int m = l.Count();
        List<bool> ans = new List<bool>();
        for(int i=0;i<m;i++)
        {
            int s = l[i];
            int e = r[i];
            List<int> res = new List<int>();
            for(int j =s; j<=e;j++)
            {
                res.Add(nums[j]);
                
            }
            res.Sort();
            int d = res[1]-res[0];
            bool flag = true;
            for(int j=2;j<=e-s;j++)
            {
                if(res[j]-res[j-1]!=d)
                {
                    flag = false;
                    break;
                }
            }
            ans.Add(flag);
        }
        return ans.ToList<bool>();
    }
}