public class Solution {
    public class Pair
    {
        public char ch;
        public int c;
        public Pair(char ch1, int c1)
        {
            ch = ch1;
            c = c1;
        }
    }
    public string RemoveDuplicates(string S, int k) {
        Stack<Pair> st = new Stack<Pair>();
        foreach(char ch in S)
        {
            
            if(st.Count()==0 || st.Peek().ch!=ch)
            {
                st.Push(new Pair(ch,1));
            }
            else
            {
                if(st.Peek().c==k-1)
                {
                    while(st.Count()>0 && st.Peek().ch==ch)
                        st.Pop();
                }
                else
                {
                    st.Push(new Pair(ch,st.Peek().c+1));
                }
            }
        }
        StringBuilder sb = new StringBuilder();
        while(st.Count()>0)
        {
            sb.Insert(0,st.Pop().ch.ToString());
        }
        return sb.ToString();
    }
}