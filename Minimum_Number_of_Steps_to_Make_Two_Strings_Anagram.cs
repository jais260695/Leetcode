public class Solution {
    public int MinSteps(string s, string t) {
        int[] ch1 = new int[26];
        int[] ch2 = new int[26];
        for(int i=0;i<s.Length;i++)
        {
            
            ch1[s[i]-97]++;
            ch2[t[i]-97]++;
        }
        int ans = 0;
        for(int i=0;i<26;i++)
        {
            if(ch1[i]!=0)
            {
                if(ch2[i]<ch1[i])
                    ans+= ch1[i]-ch2[i];
            }
            
        }
        return ans;
    }
}