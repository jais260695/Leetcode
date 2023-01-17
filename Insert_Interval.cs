public class Solution {
    public int[][] Insert(int[][] intervals, int[] newInterval) {
        int n = intervals.Count();
        List<int[]> result = new List<int[]>();
        if(n==0)
        {
            result.Add(newInterval);
            return result.ToArray();
        }
        int i = 0;
        int start = newInterval[0];
        int end = newInterval[1];
        if(newInterval[1]<intervals[0][0])
        {
            result.Add(new int[2]{start,end});
        }
        while(i<n)
        {
            if((start>= intervals[i][0] && start<=intervals[i][1]) || (end>= intervals[i][0] && end<=intervals[i][1]) || (end>= intervals[i][1] && start<=intervals[i][0]) || (i+1)<n && start>intervals[i][1] && end<intervals[i+1][0])
            {
                while((start>= intervals[i][0] && start<=intervals[i][1]) || (end>= intervals[i][0] && end<=intervals[i][1]) || (end>= intervals[i][1] && start<=intervals[i][0]))
                {
                    start = Math.Min(start,intervals[i][0]);
                    end = Math.Max(end,intervals[i][1]);
                    i++;
                    if(i==n) break;
                }
                if((i+1)<n && start>intervals[i][1] && end<intervals[i+1][0])
                {
                    result.Add(intervals[i]);
                    i++;
                }

                result.Add(new int[2]{start,end});
            }
            else
            {
                result.Add(intervals[i]);
                i++;
            }
        }

        if(newInterval[0]>intervals[n-1][1])
        {
            result.Add(new int[2]{start,end});
        }

        return result.ToArray();
    }
}