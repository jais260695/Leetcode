public class Solution {
    
    public int LengthOfLongestSubstring(string s) {
        int i=0,j=0;
        int ans =0;
        Dictionary<char,int> dict = new Dictionary<char,int>();
        int n = s.Length;
        while(j<n)
        {
            
            char val = s[j];
            if(!dict.ContainsKey(val))
            {
                dict.Add(val,j);
            }
            else
            {
                if(dict[val]+1>i)
                    i = dict[val]+1;
                dict[val] = j;
            }
            int len = j-i+1;
            if(ans<len)
            {
                ans = len;
            }
            j++;
        }
        return ans;
    }
}