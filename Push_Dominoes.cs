public class Solution {
    public string PushDominoes(string dominoes) {
        int n = dominoes.Length;
        int[] left  = new int[n];
        StringBuilder sb = new StringBuilder();
        if(dominoes[n-1]=='L')
        {
            left[n-1]  = 0;
        }
        else
        {
            left[n-1] = int.MaxValue;
        }
        for(int i=n-2;i>=0;i--)
        {
            if(dominoes[i]=='.')
            {
                left[i] = left[i+1]==int.MaxValue? left[i+1] : 1 + left[i+1];
            }
            else if(dominoes[i]=='L')
            {
                left[i] = 0;
            }
            else
            {
                left[i] = int.MaxValue;
            }
        }
        
        int right = int.MaxValue;
        
        if(dominoes[0]=='R')
        {
            right = 0;
        }
        
        if(right==left[0])
        {
            sb.Append(dominoes[0]);
        }
        else if(right<left[0])
        {
            sb.Append('R');
        }
        else
        {
            sb.Append('L');
        }
        
        for(int i = 1;i<n;i++)
        {
            if(dominoes[i]=='.')
            {
                right = right==int.MaxValue? right : 1 + right;
            }
            else if(dominoes[i]=='R')
            {
                right = 0;
            }
            else
            {
                right = int.MaxValue;
            }
            
            if(right==left[i])
            {
                sb.Append(dominoes[i]);
            }
            else if(right<left[i])
            {
                sb.Append('R');
            }
            else
            {
                sb.Append('L');
            }
            
        }
        
        
        return sb.ToString();
    }
}