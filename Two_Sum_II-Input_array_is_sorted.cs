public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        int[] res = new int[2];
        int n = numbers.Count();
        for(int i=0;i<n;i++)
        {
            res[0] = i+1;
            int val = target - numbers[i];
            int low = i+1;
            int high = n-1;
            while(low<=high)
            {
                int mid = low+(high-low)/2;
                if(numbers[mid] == val)
                {
                    res[1] = mid+1;
                    break;
                }
                else if(numbers[mid]>val)
                {
                    high = mid-1;
                }
                else
                {
                    low = mid+1;
                }
            }
            
            if(res[1]!=0) break;
            
        }
        return res;
    }
}