public class Solution {
    public int MinimumDeletions(string s) {
        int n = s.Length;
        int[] prefixBs = new int[n+1];

        for(int i=1;i<=n;i++)
        {
            prefixBs[i] = prefixBs[i-1];
            if(s[i-1]=='b')
            {
                prefixBs[i]+=1;
            }
        }
        int suffixBs = 0;
        int result = int.MaxValue;
        
        for(int i=n-1;i>=0;i--)
        {
            result = Math.Min(result,prefixBs[i]+suffixBs);
            if(s[i]=='a')
            {
                suffixBs+=1;
            }
        }

        return result;
    }
}