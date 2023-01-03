public class Solution {
    public int MinDeletionSize(string[] strs) {
        int result = 0;
        int n = strs.Count();
        int m = strs[0].Length;
        for(int i=0;i<m;i++)
        {
            int prev = -1;
            for(int j=0;j<n;j++)
            {
                int val = strs[j][i]-'a';
                if(val<prev)
                {
                    result++;
                    break;
                }
                prev = val;
            }
        }
        return result;
    }
}