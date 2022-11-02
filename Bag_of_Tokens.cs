public class Solution {
    public int BagOfTokensScore(int[] tokens, int power) {
        int n = tokens.Count();
        
        
        Array.Sort(tokens);
        int l = 0;
        int r = n-1;
        
        int score = 0;
        
        while(l<=r)
        {
            if(power >= tokens[l])
            {
                power-=tokens[l];
                score++;
                l++;
            }
            else if(score>0 && r!=l)
            {
                
                power+=tokens[r];
                score--;
                r--;
            }
            else
            {
                break;
            }
        }
        
        return score;
    }
}