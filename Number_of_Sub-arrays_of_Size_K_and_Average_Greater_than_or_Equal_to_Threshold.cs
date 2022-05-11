public class Solution {
    public int NumOfSubarrays(int[] arr, int k, int threshold) {
        int n = arr.Count();
        int sum = 0;
        
        int target = k*threshold;
        
        int result = 0;
        
        int i=0;
        int j=0;
        while(i<k)
        {
            sum+=arr[i];
            i++;
        }
        
        if(sum>=target)
        {
            result++;
        }
        
        
        while(i<n)
        {
            sum-=arr[j];
            sum+=arr[i];
            
            if(sum>=target)
            {
                result++;
            }
            
            i++;
            j++;
        }
        
        return result;
    }
}