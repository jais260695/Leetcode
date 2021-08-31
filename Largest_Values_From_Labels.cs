public class Solution {
    public class MyComparer : IComparer<int[]>
    {
        public int Compare(int[] a, int[] b)
        {
            return b[0].CompareTo(a[0]);
        }
    }
    public int LargestValsFromLabels(int[] values, int[] labels, int numWanted, int useLimit) {
        int n = values.Count();
        int[][] arr = new int[n][];
        for(int i=0;i<n;i++)
        {
            arr[i] = new int[2];
            arr[i][0] = values[i];
            arr[i][1] = labels[i];
        }
        Array.Sort(arr,new MyComparer());
        Dictionary<int,int> dict = new Dictionary<int,int>();
        int res = 0;
        int count = 0;
        for(int i=0;i<n;i++)
        {
            if(!dict.ContainsKey(arr[i][1]))
            {
                res+=arr[i][0];
                dict.Add(arr[i][1],1);
                count++;
            }
            else if(dict[arr[i][1]]<useLimit)
            {
                res+=arr[i][0];
                dict[arr[i][1]]++;
                count++;
            }
            if(count==numWanted) break;
        }
        return res;
    }
}