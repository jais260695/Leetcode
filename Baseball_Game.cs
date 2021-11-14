public class Solution {
    public int CalPoints(string[] ops) {
        Stack<int> st = new Stack<int>();
        int n = ops.Count();
        int sum = 0;
        for(int i = 0;i<n;i++)
        {
            if(ops[i]=="C")
            {
                int val = st.Pop();
                sum-=val;
            }
            else if(ops[i]=="D")
            {
                int val = 2*st.Peek();
                st.Push(val);
                sum+=val;
            }
            else if(ops[i]=="+")
            {
                int val1 = st.Pop();
                sum+=val1;
                int val2 = st.Peek();
                sum+=val2;
                st.Push(val1);
                st.Push(val1+val2);
            }
            else
            {
                int val = Convert.ToInt32(ops[i]);
                st.Push(val);
                sum+=val;
            }
        }
        return sum;
    }
}