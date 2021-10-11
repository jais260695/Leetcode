public class Solution {
    List<int> dp = new List<int>();
    int size = 2;
    public void GenerateFibonacci(int k)
    {
        dp.Add(1);
        dp.Add(1);
        while(true)
        {
            dp.Add(dp[size-1]+dp[size-2]);
            size++;
            if(dp[size-1]>k)
            {
                dp.RemoveAt(size-1);
                size--;
                break;
            }
        }
    }
    public int BinarySearch(int k)
    {
        int l = 0;
        int h = size-1;
        while(l<=h)
        {
            int mid = l + (h-l)/2;
            if(dp[mid]>k)
            {
                h = mid - 1;
            }
            else
            {
                l = mid + 1;
            }
        }
        return dp[l-1];
    }
    public int FindMinFibonacciNumbers(int k) {
        GenerateFibonacci(k);
        int count = 0;
        while(k>0)
        {
            k-=BinarySearch(k);
            count++;
        }
        return count;
    }
}