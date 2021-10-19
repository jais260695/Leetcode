public class Solution {
    public int BusyStudent(int[] startTime, int[] endTime, int queryTime) {
        int result  = 0;
        int n = startTime.Count();
        for(int i=0;i<n;i++)
        {
            if(queryTime>=startTime[i] && endTime[i]>=queryTime)
                result++;
        }
        return result;
    }
}