public class Solution {
    public int MinimumSwap(string s1, string s2) {
        int result = 0;
        int n = s1.Length;
        int xy = 0;
        int yx = 0;
        for(int i=0;i<n;i++)
        {
            if(s1[i]==s2[i])
            {
                continue;
            }
            if(s1[i]=='x' && s2[i]=='y') xy++;
            if(s1[i]=='y' && s2[i]=='x') yx++;
        }      
        result = xy/2+yx/2;       
        int xyR = xy%2;
        int yxR = yx%2;        
        if(xyR!=yxR) return -1;
        return result+xyR+yxR;
    }
}