public class Solution {

    public int CanCompleteCircuit(int[] gas, int[] cost) {
        int n = gas.Count();
        int tank = 0;
        int curr = 0;
        int start = 0;
        for(int i=0;i<n;i++)
        {
            tank+=(gas[i]-cost[i]);
            curr+=(gas[i]-cost[i]);
            if(curr<0)
            {
                start=i+1;
                curr=0;
            }
        }
        return tank<0 ? -1 : start%n;
    }
}