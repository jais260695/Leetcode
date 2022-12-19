public class Solution {
    public int[] CycleLengthQueries(int n, int[][] queries) {
        int m = queries.Count();
        int[] result = new int[m];
        
        for(int i=0;i<m;i++)
        {
            int a = queries[i][0];
            int b = queries[i][1];
            
            int hgtA = (int)(Math.Log(a)/Math.Log(2));
            int hgtB = (int)(Math.Log(b)/Math.Log(2));
            
            result[i] = 1;
            
            while(hgtA>hgtB)
            {
                
                a=a/2;
                hgtA--;
                result[i]++;
            }
            
            while(hgtB>hgtA)
            {
                
                b=b/2;
                hgtB--;
                result[i]++;
            }
            
            while(a!=b)
            {
                result[i]+=2;
                a=a/2;
                b=b/2;
            }
            
        }
        
        return result;
    }
}