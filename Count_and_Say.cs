public class Solution {
    public string FindNext(string s)
    {
        int n = s.Length;
        string temp = "";
        int i = 1;
        int count = 1;
        while(i<n)
        {
            if(s[i]!=s[i-1])
            {
                temp+=count;
                temp+=s[i-1];
                count = 0;
            }
            count++;
            i++;
        }
        temp+=count;
        temp+=s[i-1];
        return temp;
    }
    public string CountAndSay(int n) {
        string t = "1";        
        for(int i=2;i<=n;i++)
        {
           t = FindNext(t);
        }
        return t;
    }
}