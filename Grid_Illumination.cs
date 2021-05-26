public class Solution {

    public int[] GridIllumination(int n, int[][] lamps, int[][] queries) {
        IDictionary<long,long> rows = new Dictionary<long,long>();
        IDictionary<long,long> cols = new Dictionary<long,long>();
        IDictionary<long,long> diagnols1 = new Dictionary<long,long>();
        IDictionary<long,long> diagnols2 = new Dictionary<long,long>();
        
        int[] adjRows = new int[9]{0,0,0,1,-1,1,-1,1,-1}; 
        int[] adjCols = new int[9]{0,1,-1,0,0,1,-1,-1,1}; 
        
        ISet<long> bulbs = new HashSet<long>(lamps.Count());
        
        for(int i=0;i<lamps.Count();i++)
        {
            long r = lamps[i][0];
            long c = lamps[i][1];
            long bulb = n*r + c;
            if(!bulbs.Contains(bulb))
            {
                bulbs.Add(bulb);
                if(!rows.ContainsKey(r)) rows[r]=0;
                rows[r]++;
                if(!cols.ContainsKey(c)) cols[c]=0;
                cols[c]++;
                long d1 = (n-1)-(r-c);
                if(!diagnols1.ContainsKey(d1)) diagnols1[d1]=0;
                diagnols1[d1]++;
                long d2 = r+c;
                if(!diagnols2.ContainsKey(d2)) diagnols2.Add(d2,0);
                diagnols2[d2]++;
            }
        }
        
        int[] result = new int[queries.Count()];
        
        for(int i=0;i<queries.Count();i++)
        {
            long ri = queries[i][0];
            long ci = queries[i][1];
            
            if((rows.ContainsKey(ri)) || (cols.ContainsKey(ci)) || (diagnols1.ContainsKey((n-1)-(ri-ci))) || diagnols2.ContainsKey(ri+ci))
            {
                result[i] = 1;
            }
            
            for(int j=0;j<9;j++)
            {
                long r = ri+adjRows[j];
                long c = ci+adjCols[j];
                if(r<0 || c<0 || r>=n || c>=n) continue;
                long bulb = n*r + c;
                if(bulbs.Remove(bulb))
                {
                    rows[r]--;
                    if(rows[r]==0) rows.Remove(r);
                    cols[c]--;
                    if(cols[c]==0) cols.Remove(c);
                    diagnols1[(n-1)-(r-c)]--;
                    if(diagnols1[(n-1)-(r-c)]==0) diagnols1.Remove((n-1)-(r-c));
                    diagnols2[r+c]--;
                    if(diagnols2[r+c]==0) diagnols2.Remove(r+c);
                }
            }
        }
        return result;
    }
}