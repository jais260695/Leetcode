public class Solution {
    public void ReverseString(char[] s) {
        int m = s.Count();
        if(m==0) return;
        int l = m-1;
        int n = l/2;
        for(int i=0;i<=n;i++)
        {
            char temp = s[i];
            s[i] = s[l-i];
            s[l-i] = temp;
        }
    }
}