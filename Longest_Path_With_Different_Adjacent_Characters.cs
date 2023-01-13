public class Solution {
    int[] dist;
    public int LongestPathUtil(List<int>[] children, int index, string s)
    {
        int result = int.MinValue;
        PriorityQueue<int,int> pq = new PriorityQueue<int,int>();
        foreach(int child in children[index])
        {
            int childPath = LongestPathUtil(children,child,s);
            result = Math.Max(result,childPath);
            if(s[child]!=s[index])
            {
                int temp = dist[child];
                if(pq.Count<2)
                {
                    pq.Enqueue(temp,temp);
                }
                else
                {
                    if(pq.Peek()<temp)
                    {
                        pq.Dequeue();
                        pq.Enqueue(temp,temp);
                    }
                }               
            }
        }
        
        int res = 1;
        while(pq.Count>0)
        {
            dist[index] = Math.Max(dist[index],pq.Peek());         
            res+=pq.Dequeue();
        }
        result = Math.Max(result,res);
        dist[index]+=1;
        return result;

    }
    public int LongestPath(int[] parent, string s) {
        int n = s.Length;
        List<int>[] children = new List<int>[n];
        dist = new int[n];
        for(int i=0;i<n;i++)
        {
            children[i] = new List<int>();
        }

        for(int i=1;i<n;i++)
        {
            children[parent[i]].Add(i);
        }

        return LongestPathUtil(children, 0, s);
    }
}