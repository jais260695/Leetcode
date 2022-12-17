public class Solution {
    public int EvalRPN(string[] tokens) {
        int n = tokens.Count();
        Stack<int> st = new Stack<int>();
        int i = 0;
        int a,b;
        while(i<n)
        {
            switch(tokens[i])
            {
                case "*": 
                    b = st.Pop();
                    a = st.Pop();
                    st.Push(a*b);
                    break;
                case "+": 
                    b = st.Pop();
                    a = st.Pop();
                    st.Push(a+b);
                    break;
                case "/": 
                    b = st.Pop();
                    a = st.Pop();
                    st.Push(a/b);
                    break;
                case "-":
                    b = st.Pop();
                    a = st.Pop();
                    st.Push(a-b);
                    break;
                default:
                    st.Push(Convert.ToInt32(tokens[i]));
                    break;
            }
            i++;
        }

        return st.Pop();
    }
}