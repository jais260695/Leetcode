public class Solution {
    public List<string> result = new List<string>();
    
    public bool IsSafe(char ch)
    {
        int val = (int)ch;
        if(val<65)
        {
            return false;
        }
        return true;
    }
    
    public void Solve(string s, char[] temp, int i)
    {
        if(s.Length==i)
        {
            result.Add(new String(temp));
            return;
        }
        
        if(IsSafe(s[i]))
        {
            char ch = s[i];
            temp[i] = Char.ToLower(ch);;
            Solve(s,temp,i+1);
            temp[i] = Char.ToUpper(ch);
            Solve(s,temp,i+1);
        }
        else
        {
            temp[i]=s[i];
            Solve(s,temp,i+1);
        } 
    }
    public IList<string> LetterCasePermutation(string S) {
        char[] temp = new char[S.Length];
        Solve(S,temp,0);
        return result.ToList<string>();
    }
}