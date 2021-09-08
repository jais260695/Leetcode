public class Solution {
    public int CountTriplets(int[] arr) {
        int n = arr.Count();
        if(n==2) 
        {
            return (arr[0]^arr[1])==0 ? 1 : 0;
        }
        int[] prefixXOR = new int[n];
        prefixXOR[0] = arr[0];
        for(int i=1;i<n;i++)
        {
            prefixXOR[i] = prefixXOR[i-1]^arr[i];
        }
        int result = 0;
        for(int k=2;k<=n;k++)
        {
            for(int i=0;i<n-k+1;i++)
            {
                int j = i+k-1;
                int temp = prefixXOR[j];
                if(i!=0)
                {
                    temp^=prefixXOR[i-1];
                }
                if(temp==0)
                {
                    result+=(k-1);
                }
            }
        }
        return result;
    }
}