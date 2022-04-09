public class Solution {
    public int MinNumberOperations(int[] target) {
        int n = target.Count();
        int result = 0;
        int max = 0;
        int min = 100001;
        int i=0;
        while(i<n)
        {
            while(i<n && target[i]>=max)
            {
                max = target[i];
                i++;
            }
            result += max - (min==100001 ? 0 : min);
            min = 100001;
            while(i<n && target[i]<=min)
            {
                min = target[i];
                i++;
            }
            max = 0;
            
        }
        
        
        return result;
    }
}