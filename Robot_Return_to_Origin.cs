public class Solution {
    public bool JudgeCircle(string moves) {
        int i=0;
        int j=0;
        for(int u=0;u<moves.Length;u++)
        {
            if(moves[u]=='U')
            {
                j++;
            }
            else if(moves[u]=='D')
            {
                j--;
            }
            else if(moves[u]=='R')
            {
                i++;
            }
            else
            {
                i--;
            }
        }
        if(i==0 && j==0) return true;
        return false;
    }
}