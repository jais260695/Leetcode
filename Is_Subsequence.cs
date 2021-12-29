public class Solution {
    public bool IsSubsequence(string s, string t) {
        int n = s.Length;
        int m = t.Length;
        int i = 0;
        int j = 0;
        
        while(i<n && j <m)
        {
            if(s[i]==t[j])
            {
                i++;
                j++;
            }
            else
            {
                j++;
            }
        }
        
        return i==n;
    }
}