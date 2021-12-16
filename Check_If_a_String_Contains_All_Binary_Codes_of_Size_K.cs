public class Solution {
    
    public bool HasAllCodes(string s, int k) {
        HashSet<int> dp = new HashSet<int>();
        int mask = (1<<k)-1;
        int temp = 0;
        for(int i=0;i<k-1 && i<s.Length;i++)
        {
            temp = ((temp<<1) & mask ) | (s[i]-'0');
        }
        for(int i=k-1;i<s.Length;i++)
        {
            temp = ((temp<<1) & mask) | (s[i]-'0');
            dp.Add(temp);
        }
        return dp.Count==(mask+1);
    }
}