public class Solution {

    public int MinPartitions(string n) {
        int result = 0;
        foreach(char ch in n)
        {
            int t = ch-'0';
            result = Math.Max(t,result);
        }
        return result;
    }
}