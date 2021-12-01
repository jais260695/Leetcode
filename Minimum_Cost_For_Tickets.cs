public class Solution {
    public int[] dp;
    public int BinarySearch(int[] days, int val)
    {
        int l = 0;
        int h = days.Count()-1;
        while(l<=h)
        {
            int mid = l+(h-l)/2;
            if(days[mid]==val) return mid;
            if(days[mid]<val) l=mid+1;
            else h = mid-1;
        }
        return l==days.Count()?-1:l;
    }
    
    public int MincostTicketsUtil(int[] days, int[] costs, int currentDay)
    {
        if(dp[currentDay]!=0) return dp[currentDay];
        int index1 = BinarySearch(days,currentDay+1);
        int index2 = BinarySearch(days,currentDay+7);
        int index3 = BinarySearch(days,currentDay+30);
        int val1 = costs[0] + (index1==-1?0:MincostTicketsUtil(days,costs,days[index1]));
        int val2 = costs[1] + (index2==-1?0:MincostTicketsUtil(days,costs,days[index2]));
        int val3 = costs[2] + (index3==-1?0:MincostTicketsUtil(days,costs,days[index3]));
        int val = Math.Min(Math.Min(val1,val2),val3);
        dp[currentDay] = val;
        return val;
    }
    
    
    public int MincostTickets(int[] days, int[] costs) {
        int n = days.Count();
        dp = new int[days[n-1]+1];
        return MincostTicketsUtil(days,costs,days[0]);
    }
}