public class Solution {
    public void ReverseString(char[] s) {
        int l = 0;
        int r = s.Count()-1;
        while(l<r)
        {
            char temp = s[l];
            s[l++] = s[r];
            s[r--] = temp;
        }
    }
}