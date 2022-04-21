public class Solution {
    int[][] books;
    int shelfWidth;
    int n;
    
    int[,] dp;
    public int Solve(int i, int width,int height)
    {
        if(i==n) return height;
        
        
        if(dp[i,width]!=int.MaxValue) return dp[i,width];
        
        if(width-books[i][0]<0)
        {
            return dp[i,width] = height+Solve(i,shelfWidth,0);
        }
        
        return dp[i,width] =  Math.Min(
            Solve(i+1,width-books[i][0],Math.Max(height,books[i][1])),
            height + Solve(i+1,shelfWidth-books[i][0],books[i][1])
        );
    }
   
    public int MinHeightShelves(int[][] books, int shelfWidth) {
        this.books = books;
        this.shelfWidth = shelfWidth;
        n = books.Count();
        dp = new int[n,shelfWidth+1];
        for(int i=0;i<n;i++)
        {
            for(int j=0;j<=shelfWidth;j++)
                dp[i,j] = int.MaxValue;
        }
        return Solve(0,shelfWidth,0);
        
    }
}