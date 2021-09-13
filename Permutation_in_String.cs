public class Solution {
    public bool CheckInclusion(string s1, string s2) {
        int n = s1.Length;
        int m = s2.Length;
        if(n>m) return false;
        int[] arr1 = new int[26];
        int[] arr2 = new int[26];
        for(int i=0;i<n;i++)
        {
            arr1[s1[i]-'a']++;
            arr2[s2[i]-'a']++;
        }
        int c = 0;
        for(;c<26;c++)
        {
            if(arr1[c]!=arr2[c])
            {
                break;
            }
        }
        if(c==26) return true;
        for(int i=1;i<m-n+1;i++)
        {
            arr2[s2[i-1]-'a']--;
            arr2[s2[i+n-1]-'a']++;
            c = 0;
            for(;c<26;c++)
            {
                if(arr1[c]!=arr2[c])
                {
                    break;
                }
            }
            if(c==26) return true;
        }
        return false;
    }
}