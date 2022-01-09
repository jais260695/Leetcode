public class Solution {
    public int GetXORSum(int[] arr1, int[] arr2) {
        int n = arr1.Count();
        int m = arr2.Count();
        int ans1 = 0;
        for(int i=0;i<n;i++)
        {
            ans1^=arr1[i];
        }
        int ans2 = 0;
        for(int i=0;i<m;i++)
        {
            ans2^=arr2[i];
        }
        return ans1&ans2;
    }
}