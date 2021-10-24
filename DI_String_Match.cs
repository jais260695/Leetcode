public class Solution {
    public int[] DiStringMatch(string S) {
        int n = S.Length;
        int[] visit = new int[n+1];
        
        int l = 0, r = n;
        
        for(int i=0;i<n;i++)
        {
            if(S[i]=='I')
            {
                visit[i] = l;
                l++;
            }
            else
            {
                visit[i] = r;
                r--;
            }
        }
        visit[n] = l;
        return visit;
    }
}