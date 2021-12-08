public class Solution {
    public char FindTheDifference(string s, string t) {
        if(s.Length==0) return t[0];
        int ch = 0;
        for(int i =0;i<s.Length;i++)
        {
            ch^=(int)s[i];
            ch^=(int)t[i];
        }        
        ch^=(int)t[s.Length];
        return (char)ch;
    }
}