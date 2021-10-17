public class Solution {
    public string RemoveOuterParentheses(string S) {
        Stack<char> st = new Stack<char>();
        string res = "";
        int count = 0;
        int n = S.Length;
        for(int i=0;i<n;i++)
        {
            char  ch = S[i];
            if(ch=='(')
            {
                
                if(count!=0)
                {
                   res+="(";
                }
                st.Push('(');
                count++; 
                
            }
            else
            {
                if(st.Peek()=='(')
                {
                    count--;
                    if(count!=0)
                    {
                        res+=")";
                    }
                }
            }
        }
        return res;
    }
}