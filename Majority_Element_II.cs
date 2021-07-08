public class Solution {
    public IList<int> MajorityElement(int[] nums) {
        int n = nums.Count();
        int n1 = int.MinValue;
        int n2 = int.MinValue;
        int c1 = 0;
        int c2 = 0;
        
        for(int i=0;i<n;i++)
        {
            if(n1==nums[i])
            {
                c1++;
            }
            else if(n2==nums[i])
            {
                c2++;
            }
            else if(c1==0)
            {
                n1 = nums[i];
                c1++;
            }
            else if(c2==0)
            {
                n2 = nums[i];
                c2++;
            }
            else
            {
                c1--;
                c2--;
            }
        }
        c1=0;
        c2=0;
        for(int i=0;i<n;i++)
        {
            if(n1==nums[i]) c1++;
            if(n2==nums[i]) c2++;
        }
        List<int> res = new List<int>();
        if(c1>n/3) res.Add(n1);
        if(c2>n/3) res.Add(n2);
        
        return res.ToList<int>();
    }
}