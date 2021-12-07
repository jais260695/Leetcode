public class Solution {
    public int NumWaterBottles(int numBottles, int numExchange) {
        int sum = 0;
        int empty = 0;
        do{
            sum+=numBottles;
            numBottles+=empty;
            empty = numBottles%numExchange;
            numBottles = numBottles/numExchange;
        }
        while(numBottles>0);
        return sum;
    }
}