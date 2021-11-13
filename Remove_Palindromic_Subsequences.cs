public class Solution {
    public bool IsPalindrome(string s,int l,int h)
    {
        while(l<=h && s[l]==s[h])
        {
            l++;
            h--;
        }
        
        return l>h;
    }
    public int RemovePalindromeSub(string s) {
        if(s=="") return 0;
        int len = s.Length;
        bool isPalindrome = IsPalindrome(s,0,len-1);
        
        if(isPalindrome)
        {
            return 1;
        }
        else
        {
            return 2;
        }
    }
}