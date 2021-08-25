public class Solution {
    public void SortColors(int[] nums) {
        int l = 0;
        int h = 0;
        int t =0;
        
        for(int i = 0;i<nums.Count();i++)
        {
            if(nums[i]==2)
            {
                l++;
            } 
            else if(nums[i]==0)
            {
                h++;
            }
            else
                t++;
            
        }
        int z =0;
        for(int i = 0;i<h;i++)
        {
            nums[z] = 0;
            z++;
        }
        for(int i = 0;i<t;i++)
        {
            nums[z] = 1;
            z++;
            
        }
        for(int i = 0;i<l;i++)
        {
            nums[z] = 2;
            z++;
        }
    }
}