public class Solution {
    public int FindContentChildren(int[] g, int[] s) {
        Array.Sort(g);
        Array.Sort(s);
        int n = s.Count();
        int i = g.Count()-1;
        int j = n-1;
        while(i>=0 && j>=0)
        {
            if(g[i]<=s[j])
            {
                j--;
            }
            i--;
        }
        
        return n-(++j);
    }
}