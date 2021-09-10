public class Solution {
    int[] prefixSum;
    Dictionary<string,int> dict = new Dictionary<string,int>();
    public int FindResult(int l, int r,int[] nums)
    {
        if(l>r) return 0;
        string str = l+"-"+r;
        if(dict.ContainsKey(str)) return dict[str];
        if((prefixSum[r+1]-prefixSum[l])%2==0)
        {
            dict.Add(str,r-l+1);
        }
        else
        {
            int s = l+1;
            int val = 0;
            if(nums[l]>0)
            {
                while(s<r && nums[s]>0) s++;
            }
            
            if(s<r)
            {
                val = Math.Max(val,FindResult(s,r,nums));
            }
            else
            {
                val = Math.Max(val,r-l);
            }
            
            int e = r-1;
            if(nums[r]>0)
            {
                while(e>l && nums[e]>0) e--;
            }
            if(e>l)
            {
                val = Math.Max(val,FindResult(l,e,nums));
            }
            else
            {
                val = Math.Max(val,r-l);
            }
            dict.Add(str,val) ;
        }
        return dict[str];
    }
    public int GetMaxLen(int[] nums) {
        int n = nums.Count();
        prefixSum = new int[n+1];
        prefixSum[0] = 0;
        int result = 0;
        int s = 0;
        for(int i=0;i<n;i++)
        {
            if(nums[i]==0)
            {
                if(s<=i-1)
                {
                    prefixSum[i+1] = 0;
                    result = Math.Max(FindResult(s,i-1,nums),result);
                }
                s = i+1;
            } 
            else if(nums[i]<0)
            {
                prefixSum[i+1] = prefixSum[i] + 1;
            }
            else
            {
                prefixSum[i+1] = prefixSum[i];
            }
        }
        if(s<=n-1)
        {
            result = Math.Max(FindResult(s,n-1,nums),result);
        }
        return result;
    }
}