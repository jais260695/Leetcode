public class Solution {
    public IList<IList<int>> SubsetsWithDup(int[] nums) {
        int n = nums.Count();
        int val = (int)Math.Pow(2,n);
        List<List<int>> result = new List<List<int>>();
        Array.Sort(nums);
        for(int i=0;i<val;i++)
        {
            int temp = i;
            List<int> res = new List<int>();
            for(int j=0;j<n;j++)
            {
                if((temp&1) == 1)
                {
                    res.Add(nums[j]);
                }
                temp>>=1;
            }
            bool isExist = false;
            foreach(List<int> l in result)
            {
                if(Enumerable.SequenceEqual(l, res))
                {
                    isExist = true;
                    break;
                }
            }
            if(!isExist)
                result.Add(res);
        }
        return result.ToList<IList<int>>();
    }
}