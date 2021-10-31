public class Solution {
    public class Pair
    {
        public int val;
        public int freq;
        public Pair(int v, int f)
        {
            val = v;
            freq = f;
        }
    }
    public List<Pair> list = new List<Pair>();
    public void InsertPair(Pair p)
    {
        int i = list.Count();
        list.Add(p);
        int parent = (i-1)/2;
        while(i!=0 && list[parent].freq<list[i].freq)
        {
            Pair temp = list[parent];
            list[parent] = list[i];
            list[i] = temp;
            i = parent;
            parent = (i-1)/2;
        }
    }
    
    public int DecreasePair()
    {
        int i = list[0].val;
        int n = list.Count();
        list[0] = list[n-1];
        list.RemoveAt(n-1);
        MaxHeapify(0,n-1);
        return i;
    }
    
    public void MaxHeapify(int i, int n)
    {
        int left = 2*i+1;
        int right = 2*i+2;
        int largest = i;
        if(left<n && list[largest].freq<list[left].freq)
        {
            largest = left;
        }
        if(right<n && list[largest].freq<list[right].freq)
        {
            largest = right;
        }
        if(i!=largest)
        {
            Pair temp = list[i];
            list[i] = list[largest];
            list[largest] = temp;
            MaxHeapify(largest,n);
        }
    }
    
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int,int> map = new Dictionary<int,int>();
        int n = nums.Count();
        
        for(int i=0;i<n;i++)
        {
            if(!map.ContainsKey(nums[i]))
            {
                map.Add(nums[i],0);
            }
            map[nums[i]]++;
        }
        
        foreach(KeyValuePair<int,int> kv in map)
        {
            InsertPair(new Pair(kv.Key,kv.Value));
        }
        
        int[] res = new int[k];
        
        for(int i=0;i<k;i++)
        {
            res[i] = DecreasePair();
        }
        return res;
    }
}