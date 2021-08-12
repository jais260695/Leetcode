public class Solution {
    public int[] NextGreaterElements(int[] nums) {
        int n = nums.Count();
        Stack<int> st = new Stack<int>();
        int[] result = new int[n];
        Array.Fill(result,-1);
        for(int i=0;i<2*n;i++)
        {
            int j = i%n;
            while(st.Count()>0 && nums[st.Peek()]<nums[j])
            {
                result[st.Pop()] = nums[j];
            }
            
            if(i<n)
            {
                st.Push(i);
            }
        }
        return result;
    }
}