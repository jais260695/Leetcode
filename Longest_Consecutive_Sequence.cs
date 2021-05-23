public class Solution {
    public int LongestConsecutive(int[] nums) {
        HashSet<int> h = new HashSet<int>();
        int n = nums.Count();  
        int max = 0;
        for(int i=0;i<n;i++)
        {
            h.Add(nums[i]);
        }
        
        for (int i = 0; i < n;i++) { 
            if (!h.Contains(nums[i] - 1)) { 
                int val = nums[i]; 
                int count =0;
                while (h.Contains(val)) { 
                    count++;
                    val++; 
                } 
                max = Math.Max(max,count);
            } 
        } 
        return max;
    }
}