public class Solution {
    public char[][] RotateTheBox(char[][] box) {
        int n = box.Count();
        int m = box[0].Count();
        char[][] result = new char[m][];
        
        for(int i=0;i<m;i++)
        {
            result[i] = new char[n];
        }
        
        for(int j=0;j<n;j++)
        {
            for(int i=0;i<m;i++)
            {
                result[i][j] = box[n-1-j][i];
            }
        }
        
        for(int j = 0;j<n;j++)
        {
            int bottom = m;          
            for(int i=m-1;i>=0;i--)
            {
                switch(result[i][j])
                {
                    case '*':
                        bottom = i;
                        break;
                    case '#':
                        bottom--;
                        char t = result[i][j];
                        result[i][j] = result[bottom][j];
                        result[bottom][j] = t;
                        break;
                    default:
                        break;
                }
            }
        }
        
        return result;
    }
}