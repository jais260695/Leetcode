public class Solution {
    
    public double Average(int[] salary) {
        int n = salary.Count();
        int min = int.MaxValue;
        int max = int.MinValue;
        int sum = 0;
        for(int i=0;i<n;i++)
        {
            sum += salary[i];
            if(salary[i]>max)
            {
                max = salary[i];
            }
            if(salary[i]<min)
            {
                min = salary[i];
            }
        }
        sum-=(min+max);
        return (double)sum/(double)(n-2);
    }
}