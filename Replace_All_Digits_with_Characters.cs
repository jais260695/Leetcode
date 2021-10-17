public class Solution {
    public char Shift(char ch, int inc)
    {
        return (char)((int)ch + inc);
    }
    public string ReplaceDigits(string s) {
        StringBuilder sb = new StringBuilder();
        for(int i=0;i<s.Length;i++)
        {
            if(i%2==0)
            {
                sb.Append(s[i]);
            }
            else
            {
                char ch = Shift(s[i-1],s[i]-'0');
                sb.Append(ch);
            }
        }
        return sb.ToString();
    }
}