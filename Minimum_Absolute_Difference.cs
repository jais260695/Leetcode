public class Solution {
    public IList<IList<int>> MinimumAbsDifference(int[] arr) {
        Array.Sort(arr);
        int n = arr.Count();
        int min = int.MaxValue;
        List<List<int>> result = new List<List<int>>();
        for(int i=0;i<n-1;i++)
        {
            int diff = arr[i+1] - arr[i];
            if(min==diff)
            {
                result.Add(new List<int>{arr[i],arr[i+1]});
            }
            else if(min>diff)
            {
                min = diff;
                result = new List<List<int>>();
                result.Add(new List<int>{arr[i],arr[i+1]});
            }
            
        }
        
        return result.ToList<IList<int>>();
    }
}