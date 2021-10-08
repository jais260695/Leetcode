public class Solution {
    public bool Solve(string s1, string s2, int n)
    {
        for(int i=0;i<n;i++)
        {
            if(s1[i]>s2[i]) return false;
        }
        return true;
    }
    public bool CheckIfCanBreak(string s1, string s2) {
        char[] c = s1.ToCharArray();
        Array.Sort(c);
        s1 = new String(c);
        
        c = s2.ToCharArray();
        Array.Sort(c);
        s2 = new String(c);
        
        int n = s1.Length;
        return Solve(s1,s2,n) || Solve(s2,s1,n);
    }
}