public class Solution {
    public int ScoreOfParentheses(string s) {
        int open = 0;
        int score = 0;
        int i = 0;
        while(i<s.Length)
        {
            if(s[i]=='(')
            {
                open++;
                i++;
            }
            else
            {
                score+= (int)Math.Pow(2,open-1);
                while(i<s.Length && s[i]==')')
                {
                    open--;
                    i++;
                }
            }
        }
        
        return score;
    }
}