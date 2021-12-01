public class Solution {
    public int FindLucky(int[] arr) {
        int[] res = new int[501];
        
        for(int i=0;i<arr.Count();i++)
        {
            res[arr[i]]++;
        }
        
        for(int i=500;i>=1;i--)
        {
           if(res[i]==i) return i;
        }
        
        return -1;
             
    }
}