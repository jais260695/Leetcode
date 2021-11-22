public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        int n = temperatures.Count();
        int[] res = new int[n];
        Stack<int> st = new Stack<int>();
        for(int i=0;i<n;i++)
        {
            while(st.Any() && temperatures[i]>temperatures[st.Peek()])
            {
                int j = st.Pop();
                res[j] = i-j;
            }
            st.Push(i);
        }
        return res;
    }
}