public class Solution {
    public int WaysToMakeFair(int[] nums) {
        int n = nums.Count();
        int oddLeft = 0;
        int evenLeft = 0;
        int oddRight = 0;
        int evenRight = 0;
        int res=0;
        for(int i=0;i<n;i++)
        {
            if(i%2==0)
            {
                evenRight+=nums[i];
            }
            else
            {
                oddRight+=nums[i];
            }
        }
        for(int i=0;i<n;i++)
        {
            if(i%2==0)
            {
                evenRight-=nums[i];
            }
            else
            {
                oddRight-=nums[i];
            }
            int temp = oddRight;
            oddRight = evenRight;
            evenRight = temp;
            
            if(evenLeft+evenRight==oddLeft+oddRight) res++;
            
            if(i%2==0)
            {
                evenLeft+=nums[i];
            }
            else
            {
                oddLeft+=nums[i];                
            }
            temp = oddRight;
            oddRight = evenRight;
            evenRight = temp;
        }
        return res;
    }
}