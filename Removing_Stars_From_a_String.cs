public class Solution {
    public string RemoveStars(string s) {
        Stack<char> st = new Stack<char>();
        foreach(char ch in s)
        {
            if(ch=='*')
            {
                st.Pop();
            }
            else
            {
                st.Push(ch);
            }
        }
        
        char[] sb = new char[st.Count()];
        
        int i = st.Count()-1;
        while(st.Count()>0)
        {
            sb[i] = st.Pop();
            i--;
        }
        
        return new String(sb);
    }
}