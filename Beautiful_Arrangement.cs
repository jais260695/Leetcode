public class Solution {
    int result = 0;
    public bool[] visited;
    public int lastLevel;
    public void CountPermutaions(int l)
    {
        if(l==lastLevel+1)
        {
            result++;
        }
        
        for(int i=1;i<=lastLevel;i++)
        {
            if(!visited[i] && (i%l==0 || l%i==0))
            {
                visited[i] = true;
                CountPermutaions(l+1);
                visited[i] = false;
            }
        }
    }
    public int CountArrangement(int n) {
        visited = new bool[n+1];
        lastLevel = n;
        CountPermutaions(1);
        return result;
    }
}