public class Solution {
    public int Sum (int[] nums, int n, int k)
    {
        int temp = 0;
        for(int i=0;i<n;i++)
        {
            temp+=(int)Math.Ceiling((double)nums[i]/k);
        }
        return temp;
    }
    public int SmallestDivisor(int[] nums, int threshold) {
        int n = nums.Count();
        int l = 1;
        int h = 1000000;
        while(l<=h)
        {
            int mid = l+(h-l)/2;
            int sum = Sum(nums,n,mid);
            if(sum<=threshold)
            {
                h = mid -1;
            }
            else
            {
                l = mid +1;
            }
        }
        return l;
    }
}