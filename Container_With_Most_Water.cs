public class Solution {
    public int MaxArea(int[] height) 
    {
        int result = 0;
        int n = height.Count();
        int l = 0;
        int r = n-1;
        while(l<r)
        {
            if(height[l]<=height[r])
            {
                int area = (r-l) * height[l];
                result = Math.Max(result,area);
                l++;
            }
            else
            {
                int area = (r-l) * height[r];
                result = Math.Max(result,area);
                r--;
            }        
        }
        return result;
    }
}