public class Solution {
    public int MaxSum(int[] nums1, int[] nums2) {
        int n1 = nums1.Count();
        int n2 = nums2.Count();
        long[] dp1 = new long[n1+1];
        long[] dp2 = new long[n2+1];  
        int mod = 1000000007;
        Dictionary<int,int> dict = new Dictionary<int,int>();
        dp1[n1] = 0;
        dp2[n2] = 0;
        
        for(int i=0;i<n2;i++)
        {
            dict.Add(nums2[i],i);
        }
        int e = n2-1;
        for(int i=n1-1;i>=0;i--)
        {
            dp1[i] = (dp1[i+1] + nums1[i]);
            if(dict.ContainsKey(nums1[i]))
            {
                int index = dict[nums1[i]];
                for(int j = e;j>=index;j--)
                {
                    dp2[j] = (dp2[j+1]+nums2[j]);
                }
                long maxValue = Math.Max(dp1[i],dp2[index]);
                dp1[i] = maxValue;
                dp2[index] = maxValue;
                e = index -1;
            }
        }
        for(int j = e;j>=0;j--)
        {
            dp2[j] = (dp2[j+1] + nums2[j]);
        }
        return (int)(Math.Max(dp1[0],dp2[0])%mod);
    }
}