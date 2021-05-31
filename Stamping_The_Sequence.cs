public class Solution {
    public int Verify(string stamp, StringBuilder target, int n, int m)
    {
        for(int i=0;i<n;i++)
        {
            int j = 0;
            int flag = 0;
            for(;j<m && (i+j)<n ; j++)
            {
                if(target[i+j]=='?')
                {
                    continue;
                }
                else if(target[i+j]==stamp[j])
                {
                    flag = 1;
                }
                else
                {
                    break;
                }
            }
            
            if(j==m && flag==1)
            {
                for(int k=0;k<m;k++)
                {
                    target[i+k] = '?';
                }
                return i;
            }
        }
        return -1;
    }
    public int[] MovesToStamp(string stamp, string target) {
        int n = target.Length;
        int m = stamp.Length;
        List<int> result = new List<int>();
        
        StringBuilder sb = new StringBuilder(target);
        
        string temp = "";
        for(int i=0;i<n;i++) temp+="?";
        while(sb.ToString()!=temp)
        {
            int index = Verify(stamp, sb,n,m);
            if(index==-1) return new int[0];
            result.Add(index);
        }
         result.Reverse();
        return result.ToArray();
    }
}