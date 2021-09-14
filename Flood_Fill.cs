public class Solution {
    int[] x = new int[4]{0,0,1,-1};
    int[] y = new int[4]{1,-1,0,0};
    public void DFS(int i, int j,int[][] image, int n, int m,int newColor,int color)
    {
        image[i][j] = newColor;
        for(int k=0;k<4;k++)
        {
            int u = i+x[k];
            int v = j+y[k];
            if(u>=0 && u<n && v>=0 && v<m)
            {
                if(image[u][v]!=newColor && image[u][v]==color)
                {
                    DFS(u,v,image,n,m,newColor,color);
                }
            }
        }
    }
    public int[][] FloodFill(int[][] image, int sr, int sc, int newColor) {
        int n = image.Count();
        int m = image[0].Count();
        DFS(sr,sc,image,n,m,newColor,image[sr][sc]);
        return image;
    }
}