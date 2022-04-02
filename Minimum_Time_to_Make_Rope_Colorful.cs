public class Solution {
    public int MinCost(string colors, int[] neededTime) {
        int n = neededTime.Count();
        
        int result =  0;
        
        int sum = 0;
        int max = 0;
        int i=0;
        while(i<n)
        {
            sum = 0;
            max = 0;
            while(i<n-1 && colors[i]==colors[i+1])
            {
                sum+=neededTime[i];
                max = Math.Max(max,neededTime[i]);
                i++;
            }
            sum+=neededTime[i];
            max = Math.Max(max,neededTime[i]);
            result+= (sum-max);
            i++;            
        }
        
        return result;
    }
}