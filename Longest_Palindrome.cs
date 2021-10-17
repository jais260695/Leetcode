public class Solution {
    public int LongestPalindrome(string s) {
        Dictionary<char,int> dict = new Dictionary<char,int>();
        foreach(char ch in s)
        {
            if(!dict.ContainsKey(ch))
            {
                dict.Add(ch,0);
            }
            dict[ch]++;
        }
        bool isOdd = false;
        int ans = 0;
        foreach(KeyValuePair<char,int> kvp in dict)
        {
            if(kvp.Value%2==0)
            {
                ans+=kvp.Value;
            }
            else
            {
                ans+=kvp.Value-1;
                isOdd = true;
            }
        }
        return isOdd?ans+1:ans;
    }
}