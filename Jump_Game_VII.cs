public class Solution {
    public bool CanReach(string s, int minJump, int maxJump) {
        int n = s.Length;
        bool[] visited = new bool[n];
        
        if(s[n-1]=='1') return false;
        
        Queue<int> queue = new Queue<int>();
        queue.Enqueue(0);
        int fd = 0;
        while(queue.Count()>0)
        {
            int i = queue.Dequeue();
            int l = Math.Max(i+minJump,fd);
            int r = Math.Min(i+maxJump,n-1);
            for(int j =l;j<=r;j++)
            {                
                if(s[j]=='0')
                {
                    if(j==n-1) return true;
                    queue.Enqueue(j);
                }
            }
            fd = r+1;
        }
        return false;
    }
}