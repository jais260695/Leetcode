public class Solution {
    public int LongestContinuousSubstring(string s) {
        int i = 0;
        int j = 0;
        int prev = -1;
        int ans = 0;
        int n = s.Length;
        
        while(j<n)
        {
            int temp = s[j]-'a';
            if(prev==-1 || temp==(prev+1))
            {
                prev = temp;
            }
            else
            {
                ans = Math.Max(ans,j-i);
                prev = temp;
                i = j;
            }
            j++;
        }
        
        ans = Math.Max(ans,j-i);
        
        return ans;
    }
}