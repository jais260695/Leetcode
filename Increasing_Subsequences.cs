public class Solution {
    public IList<IList<int>> FindSubsequences(int[] nums) {
        int n = nums.Count();
        int m = 1<<n;
        
        List<List<int>> result = new List<List<int>>();
        HashSet<string> map = new HashSet<string>();
        
        for(int i=0;i<m;i++)
        {
            List<int> tempResult = new List<int>();
            StringBuilder sb = new StringBuilder();
            int prev = -101;
            bool sorted = true;
            for(int j=0;j<n;j++)
            {
                int val = 1<<j;
                if((i&(1<<j)) == val )
                {
                    if(nums[j]>=prev)
                    {
                        prev = nums[j];
                        sb.Append(nums[j]);
                        sb.Append("|");
                        tempResult.Add(nums[j]);
                    }
                    else
                    {
                        sorted = false;
                        break;
                    }
                }
            }
            
            if(sorted && tempResult.Count()>=2)
            {
                string s = sb.ToString();
                if(!map.Contains(s))
                {
                    map.Add(s);
                    result.Add(tempResult);
                }
            }
        }
        
        return result.ToList<IList<int>>();
    }
}