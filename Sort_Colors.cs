public class Solution {
    public void Swap(int[] nums, int i, int j)
    {
        int temp = nums[i];
        nums[i] = nums[j];
        nums[j] = temp;
    }
    public void SortColors(int[] nums) {
        int n = nums.Count();
        int l = -1;
        int h = n;
        int i=0;
        while(l<h && i<h)
        {
            if(nums[i]==0)
            {
                l++;
                Swap(nums,l,i);
            }
            else if(nums[i]==2)
            {
                h--;
                Swap(nums,i,h);
            }
            else
            {
                i++;
            }
            if(i==l) i++;
        }
    }
}