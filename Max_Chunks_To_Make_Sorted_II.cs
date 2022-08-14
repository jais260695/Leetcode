public class Solution {
    public int MaxChunksToSorted(int[] arr) {
        int n = arr.Count();           
        Stack<int> st = new Stack<int>();     
        st.Push(arr[0]);
        
        int i = 1;
        
        while(i<n)
        {
            int max = arr[i];
            while(st.Count() > 0 && arr[i] < st.Peek())
            {
                max = Math.Max(max,st.Pop());
            }
            st.Push(max);
            i++;
        }

        return st.Count();
    }
}