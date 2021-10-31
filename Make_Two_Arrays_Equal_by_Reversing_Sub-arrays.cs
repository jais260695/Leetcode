public class Solution {
    public bool CanBeEqual(int[] target, int[] arr) {
        Array.Sort(target);
        Array.Sort(arr);
        int n = target.Count();
        for(int i=0;i<n;i++)
        {
            if(target[i]!=arr[i])
                return false;
        }
        return true;
    }
}