public class Solution {
    public int DFS(int i, int j, int[][] matrix, bool[,] visited, int n, int m)
    {
        int count =1;
        visited[i,j] = true;
        if(i-1>=0)
        {
            if(matrix[i-1][j]==1)
            {
                if(!visited[i-1,j])
                    count += DFS(i-1,j,matrix,visited,n,m);
            }
        }
        if(i+1<n)
        {
            if(matrix[i+1][j]==1)
            {
                if(!visited[i+1,j])
                    count += DFS(i+1,j,matrix,visited,n,m);
            }
        }
        if(j-1>=0)
        {
            if(matrix[i][j-1]==1)
            {
                if(!visited[i,j-1])
                    count += DFS(i,j-1,matrix,visited,n,m);
            }
        }
        if(j+1<m)
        {
            if(matrix[i][j+1]==1)
            {
                if(!visited[i,j+1])
                    count += DFS(i,j+1,matrix,visited,n,m);
            }
        }
        
        return count;
    }
    public int LargestIsland(int[][] matrix) {
        int n = matrix.Count();
        if(n==0) return 0;
        int m = matrix[0].Count();
        bool[,] visited = new bool[n,m];
        
        int max = 0;
        
        for(int i =0;i<n;i++)
        {
            for(int j = 0; j<m;j++)
            {
                    visited = new bool[n,m];
                    int val = DFS(i,j,matrix,visited,n,m);
                    max = Math.Max(max,val);
            }
        }
        return max;
    }
}