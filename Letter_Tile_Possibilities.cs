public class Solution {
    
    int Solve(int[] count)
    {
        int sum = 0;
        for(int i=0;i<26;i++)
        {
            if(count[i] == 0) continue;
            count[i]-=1;
            sum++;
            sum+=Solve(count);
            count[i]+=1;
        }
        return sum;
    }
    
    public int NumTilePossibilities(string tiles) {
        int[] count = new int[26];
        foreach(char ch in tiles)
        {
            count[ch-65]+=1;
        }
        
        return Solve(count);
    }
}