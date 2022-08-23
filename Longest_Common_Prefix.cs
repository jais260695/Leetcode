public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        int n = strs.Length;
        Array.Sort(strs); 
        
        int i = 0;
        
        while( i<strs[0].Length && i<strs[n-1].Length && strs[0][i]==strs[n-1][i])
        {
            i++;
        }
        
        return strs[0].Substring(0,i);
    }
}