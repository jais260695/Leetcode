public class Solution {
    public bool EscapeGhosts(int[][] ghosts, int[] target) {
        int myDist = Math.Abs(target[0]) + Math.Abs(target[1]);
        int n = ghosts.Count();
        for(int i=0;i<n;i++)
        {
            int gDist = Math.Abs(target[0]-ghosts[i][0]) + Math.Abs(target[1]-ghosts[i][1]);
            if(gDist<=myDist) return false;
        }
        return true;
    }
}