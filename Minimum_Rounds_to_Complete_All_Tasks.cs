public class Solution {
    public int MinimumRounds(int[] tasks) {
        int n = tasks.Count();
        Array.Sort(tasks);
        int i = 0;
        int result = 0;
        while(i<n)
        {
            int val = tasks[i];
            int j = i+1;
            while(j<n && tasks[j]==val)
            {
                j++;
            }

            int count = j - i;

            if(count==1) return -1;
            
            while((count-3)>0 && (count-3)!=1)
            {
                result++;
                count-=3;
            }

            if(count==3)
            {
                result++;
            }
            else
            {
                result+= count/2;
            }

            i = j;
        }

        return result;
    }
}