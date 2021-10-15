public class Solution {
    public int[] Shuffle(int[] nums, int n) {
        int m = 2*n;
        int[] newNums = new int[m];
        int k=0;
        for(int i=0,j=n;i<n;i++,j++)
        {
            newNums[k] = nums[i];
            newNums[k+1] = nums[j];
            k+=2;
        }
        return newNums;
    }
}