public class Solution {
    public IList<int> GoodDaysToRobBank(int[] security, int time) {
        int n = security.Count();
        int[] left = new int[n];
        int[] right = new int[n];
        
        left[0] = 1;
        right[n-1] = 1;
        
        for(int i=1;i<n;i++)
        {
            left[i] = 1;
            if(security[i]<=security[i-1])
            {
                left[i] += left[i-1];
            }
            
            int j = (n-1)-i;
            right[j] = 1;
            
            if(security[j]<=security[j+1])
            {
                right[j] += right[j+1];
            } 
        }
        
        List<int> result = new List<int>();
        
        for(int i=0;i<n;i++)
        {
            if(left[i]>time && right[i]>time)
            {
                result.Add(i);
            }
        }
        
        return result.ToList<int>();
    }
}