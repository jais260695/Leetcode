public class Solution {
    public IList<IList<int>> KSmallestPairs(int[] nums1, int[] nums2, int k) {
        PriorityQueue<Tuple<int,int>,int> pq = new PriorityQueue<Tuple<int,int>,int>(Comparer<int>.Create((x, y) => y - x));
        int n = nums1.Count();
        int m = nums2.Count();
        int count = 0;
        for(int i=0;i<n;i++)
        {
            for(int j=0;j<m;j++)
            {             
                
                pq.Enqueue(new Tuple<int,int>(nums1[i],nums2[j]),nums1[i]+nums2[j]);     
                k--;
                if(k<0)
                {
                    pq.Dequeue();
                }      
            }
        }

        List<List<int>> result = new List<List<int>>();

        while(pq.Count>0)
        {
            Tuple<int,int> t = pq.Dequeue();
            result.Insert(0,new List<int>(){t.Item1,t.Item2});
        }

        return result.ToList<IList<int>>();
    }
}