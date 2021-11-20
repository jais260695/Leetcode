public class Solution {
    public int[] RelativeSortArray(int[] arr1, int[] arr2) {
        Dictionary<int, int> dict = new Dictionary<int, int>();
        int n1 = arr1.Count();
        Array.Sort(arr1);
        int n2 = arr2.Count();
        for(int i=0;i<n2;i++)
        {
            dict.Add(arr2[i],0);
        }
        
        for(int i=0;i<n1;i++)
        {
            if(!dict.ContainsKey(arr1[i]))
            {
                dict.Add(arr1[i],0);
            }
            dict[arr1[i]]++;
        }
        
        int j=0;
        foreach(var d in dict)
        {
            int n = d.Value;
            int val = d.Key;
            for(int i=0;i<n;i++)
            {
                arr1[j] = val;
                j++;
            }
        }
        return arr1;
    }
}