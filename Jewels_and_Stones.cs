public class Solution {
    public int NumJewelsInStones(string J, string S) {
        int result = 0;
        char[] ch = S.ToCharArray();
        foreach(char c in J)
        {
            result+=S.Count(s=>s==c);
        }
        return result;
    }
}