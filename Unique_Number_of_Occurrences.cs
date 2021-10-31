public class Solution {
    public bool UniqueOccurrences(int[] arr) {
        Dictionary<int,int> dict = new Dictionary<int,int>();
        for(int i =0;i<arr.Count();i++)
        {
            if(!dict.ContainsKey(arr[i]))
            {
                dict.Add(arr[i],0);
            }
            dict[arr[i]]++;
        }
        
        HashSet<int> list = new HashSet<int>();
        foreach(KeyValuePair<int,int> k in dict)
        {
            if(list.Contains(k.Value))
            {
                return false;
            }
            list.Add(k.Value);
        }
        return true;
        
    }
}