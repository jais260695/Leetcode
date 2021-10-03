public class Solution {
    int[] arr;
    int[] tArr;
    int n;
    Random rand;
    public Solution(int[] nums) {
        n = nums.Count();
        tArr = new int[n];
        rand = new Random();
        arr = nums;
        Array.Copy(nums,tArr,n);
    }
    
    public void Swap(int i, int j)
    {
        int temp = tArr[i];
        tArr[i] = tArr[j];
        tArr[j] = temp;
    }
    
    public int[] Reset() {
        return arr;
    }
    
    public int[] Shuffle() {
        int i = rand.Next(n);
        int j = rand.Next(n);
        while(i==j)
        {
            i = rand.Next(n);
            j = rand.Next(n);
        }
        Swap(i,j);
        return tArr;
    }
}

/**
 * Your Solution object will be instantiated and called as such:
 * Solution obj = new Solution(nums);
 * int[] param_1 = obj.Reset();
 * int[] param_2 = obj.Shuffle();
 */