public class Solution {
    public int CountTriplets(int[] arr) {
        int n = arr.Count();
        int[] prefixXOR = new int[n];
        prefixXOR[0] = arr[0];
        for(int i=1;i<n;i++)
        {
            prefixXOR[i] = prefixXOR[i-1]^arr[i];
        }
        int result = 0;
        for(int k=1;k<n;k++)
        {
            for(int i=0,j=k;j<n;i++,j++)
            {
                int temp = prefixXOR[j];
                if(i!=0)
                {
                    temp^=prefixXOR[i-1];
                }
                if(temp==0)
                {
                    result+=k;
                }
            }
        }
        return result;
    }
}