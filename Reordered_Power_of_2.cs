public class Solution {
    public bool ReorderedPowerOf2(int N) {
        int[] arr1 = Calculate(N);
        for(int i=0;i<31;i++)
        {
            int val = 1<<i;
            int[] arr2 = Calculate(val);
            if(Compare(arr1, arr2))
            {
                return true;
            }
        }
        return false;
    }
    
    public int[] Calculate(int N)
    {
        int[] temp = new int[10];
        while(N>0)
        {
            int mod = N%10;
            temp[mod]++;
            N = N/10;
        }
        return temp;
    }
    
    public bool Compare(int[] arr1, int[] arr2)
    {
        for(int i=0;i<10;i++)
        {
            if(arr1[i]!=arr2[i])
            {
                return false;
            }
        }
        return true;
    }
}