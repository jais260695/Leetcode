public class Solution {
    public int[] ExecuteInstructions(int n, int[] startPos, string s) {
        int m = s.Length;
        int[] result = new int[m];
        for(int i=0;i<m;i++)
        {
            int x = startPos[0];
            int y = startPos[1];
            int j =i;
            for(; j<m;j++)
            {
                switch(s[j])
                {
                    case 'R' :
                        y++;
                        break;
                    case 'L' :
                        y--;
                        break;
                    case 'D' :
                        x++;
                        break;
                    case 'U' :
                        x--;
                        break;
                    default :
                        continue;
                }
                
                if(x>=n || x<0 || y>=n || y<0)
                {
                    result[i] = j-i;
                    break;
                }
            }
            if(j==m)
            {
                result[i] = j-i;
            }
        }
        
        return result;
    }
}