public class Solution {
    public void Swap(int[] A, int i, int j)
    {
        int temp = A[j];
        for(int k=j;k>i;k--)
        {
            A[k] = A[k-1];
        }
        A[i] = temp;
    }
    public int BinarySearch(int[] A,int l, int h, int val)
    {
        int start = l;
        while(l<=h)
        {
            int mid = l+(h-l)/2;
            if(A[mid]<=val)
            {
                l = mid + 1;
            }
            else
            {
                h = mid - 1;
            }
                
        }
        return l==A.Count()?start:l;
    }
    public int[] AdvantageCount(int[] A, int[] B) {
        int n = A.Count();
        Array.Sort(A);
        for(int i=0;i<n;i++)
        {
            int index = BinarySearch(A,i,n-1,B[i]);
            Swap(A,i,index);
        }
        return A;
    }
}