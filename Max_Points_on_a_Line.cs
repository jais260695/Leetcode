public class Solution {
    public int MaxPoints(int[][] points) {
        Dictionary<int,Dictionary<int,int>> dict = new Dictionary<int,Dictionary<int,int>>();
        int n = points.Count();
        if(n==1) return 1;
        int result = 0;
        for(int i=0;i<n-1;i++)
        {
            int collinearCount = 0;
            int sameLine = 0;
            dict = new Dictionary<int,Dictionary<int,int>>();
            for(int j=i+1;j<n;j++)
            {
                int x = points[j][0]-points[i][0];
                int y = points[j][1]-points[i][1];
                if(x==0 && y==0)
                {
                    collinearCount++;
                    continue;
                }
                int cm = GCD(x,y);
                if(cm!=0)
                {
                    x/=cm;
                    y/=cm;
                }
                if(dict.ContainsKey(x))
                {
                    if(dict[x].ContainsKey(y))
                    {
                        dict[x][y]++;
                    }
                    else
                    {
                        dict[x].Add(y,1);
                    }
                }
                else
                {
                    dict.Add(x,new Dictionary<int,int>());
                    dict[x].Add(y,1);
                }
                sameLine = Math.Max(sameLine,dict[x][y]);
            }
            result = Math.Max(result,1+collinearCount + sameLine);
        }
        return result;
    }
    public int GCD(int a,  int b)
    {
        if(b==0) return a;
        return GCD(b,a%b);
    }
}