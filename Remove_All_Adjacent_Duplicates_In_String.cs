public class Solution {
    public string RemoveDuplicates(string S) {
        Stack<char> st = new Stack<char>();
        int n = S.Length;
        int i=0;
        while(i<n)
        {
            if(st.Count()==0)
            {
                st.Push(S[i]);
                i++;
            }
            else
            {
                if(st.Peek()==S[i])
                {
                    st.Pop();
                    i++;
                }
                else
                {
                    st.Push(S[i]);
                    i++;
                }
            }
        }
        string res ="";
        while(st.Count()>0)
        {
            res = res.Insert(0,st.Pop().ToString());
        }
        return res;
    }
}