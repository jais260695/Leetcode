public class Solution {
    public int MinFlips(string target) {
        int n = target.Length;
        char ch = '0';
        int result = 0;
        for(int i=0;i<n;i++)
        {
            if(ch!=target[i])
            {
                ch = target[i];
                result++;
            }
        }
        return result;
    }
}