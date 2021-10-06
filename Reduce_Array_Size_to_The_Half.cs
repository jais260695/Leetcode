public class Solution {
    public int MinSetSize(int[] arr) {
        int n = arr.Count();
        Dictionary<int,int> map = new Dictionary<int,int>();
        for(int i=0;i<n;i++)
        {
            if(!map.ContainsKey(arr[i]))
            {
                map.Add(arr[i],0);
            }
            map[arr[i]]++;
        }
        int len = n/2;
        int count = 0;
        //maxheap can also be used while incrementing the count above
        foreach (KeyValuePair<int, int> kvp in map.OrderByDescending(m => m.Value))  
        {  
            len-=kvp.Value;
            count++;
            if(len<=0)
            {
                break;
            }
        }  
        return count;
    }
}