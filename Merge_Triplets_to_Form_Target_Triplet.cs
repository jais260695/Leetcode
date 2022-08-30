public class Solution {
    public bool MergeTriplets(int[][] triplets, int[] target) {
        
        int[] tempTriplet = new int[3];
        int n = triplets.Count();
        
        for(int i=0;i<n;i++)
        {
            if(triplets[i][0] <= target[0] && triplets[i][1] <= target[1] && triplets[i][2] <= target[2])
            {
                tempTriplet[0] = Math.Max(tempTriplet[0], triplets[i][0]);
                tempTriplet[1] = Math.Max(tempTriplet[1], triplets[i][1]);
                tempTriplet[2] = Math.Max(tempTriplet[2], triplets[i][2]);
            }
        }
        
        return tempTriplet[0]==target[0] && tempTriplet[1]==target[1] && tempTriplet[2]==target[2]; 
    }
}