public class Solution {
    public int MinCostToMoveChips(int[] position) {
        int countZero = 0;
        int n = position.Count();
        for(int i = 0; i < n; i++){
            if(position[i] % 2 == 0){
                countZero++;
            }
        }
        return Math.Min(countZero,n-countZero);
    }
}