public class Solution {
    public long WaysToBuyPensPencils(int total, int cost1, int cost2) {
        int possiblePens = 0;
        long possibleWays = 0;
        while(cost1*possiblePens<=total)
        {
            possibleWays += (total-(cost1*possiblePens))/cost2;
            possibleWays++;
            
            possiblePens++;
        }
        
        return possibleWays;
    }
}