public class Solution {
    public class Pair
    {
        public int pos;
        public char spec;
        public Pair(int p, char s)
        {
            pos = p;
            spec = s;
        }
    }
    public class PairComparer:IComparer<Pair>
    {
        public int Compare(Pair p1, Pair p2)
        {
            if(p1.pos!=p2.pos) return p1.pos-p2.pos;
            return p2.spec-p1.spec;
        }
    }
    public IList<int> PartitionLabels(string s) {
        Dictionary<char,int[]> intervals  = new Dictionary<char,int[]>();
        int n = s.Length;
        int i =0;
        for(;i<n;i++)
        {
            if(!intervals.ContainsKey(s[i]))
            {
                intervals.Add(s[i],new int[2]);
                intervals[s[i]][0] = i;
                intervals[s[i]][1] = i;
            }
            else
            {
                intervals[s[i]][1] = i;
            }
        }
        int m = intervals.Count()*2;
        i = 0;
        Pair[] points = new Pair[m];
        foreach(KeyValuePair<char,int[]> kvp in intervals)
        {
            points[i]=new Pair(kvp.Value[0],'s');
            points[i+1] = new Pair(kvp.Value[1],'e');
            i+=2;            
        }
        Array.Sort(points,new PairComparer());
        List<int> result = new List<int>();
        i=0;
        while(i<m)
        {
            int j = i+1;
            if(points[i].spec=='s')
            {
                int cs = 1;
                int ce = 0;
                while(j<m && cs!=ce)
                {
                    if(points[j].spec=='s')
                    {
                        cs++;
                    }
                    else
                    {
                        ce++;
                    }
                    if(cs==ce)
                    {
                        result.Add(points[j].pos-points[i].pos+1);
                        j++;
                        break;
                    }
                    j++;
                }
            }
            i=j;
        }
        return result.ToList<int>();
    }
}