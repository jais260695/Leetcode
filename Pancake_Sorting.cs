public class Solution {
    public IList<int> PancakeSort(int[] A) {  
        int n=A.Count();
        List<int> result = new List<int>();
        while(n!=1)
        {
            int i=Array.IndexOf(A,n);
            int k=i+1;
            if(k!=1)
            {
                Array.Reverse(A, 0, k );
                result.Add(k);
            }
            Array.Reverse(A, 0, n );
            result.Add(n);
            n--;
        }
        return result;    
    }
}