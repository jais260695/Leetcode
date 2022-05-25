public class Solution {
    public int MaxChunksToSorted(int[] arr) {
        int n = arr.Count();

        Stack<int> st = new Stack<int>();
        st.Push(arr[0]);
        int i = 1;
        while(i<n)
        {
            int curr = arr[i];
            if(curr > st.Peek())
            {
                if(i<=st.Peek())
                {
                    st.Pop();
                }
                st.Push(curr);
            }
            
            i++;
        }
        
        return st.Count();
    }
}