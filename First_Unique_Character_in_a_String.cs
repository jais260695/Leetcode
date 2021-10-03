public class Solution {
    public int FirstUniqChar(string s) {
        int n = s.Length;
        int[] dict = new int[26];
        for(int i=0;i<n;i++)
        {
            dict[s[i]-'a']++;
        }
        
        for(int i=0;i<n;i++)
        {
            if(dict[s[i]-'a']==1)
            {
                return i;
            }
        }
        return -1;
    }
}