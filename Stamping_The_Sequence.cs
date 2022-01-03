public class Solution {
    public int Verify(string stamp, StringBuilder target, int n, int m)
    {
        int flag=0; 
        int i = 0;
        Queue<int> queue = new Queue<int>();
        while(i<n)
        {
            if(target[i]=='?')
            {
                queue.Enqueue(i);
            }
            else if(target[i]==stamp[queue.Count()])
            {
                queue.Enqueue(i);
                flag=1;
            }
            else
            {
                if(queue.Count()>0)
                    i = queue.Peek();
                queue.Clear();
                flag = 0;
            }
            if(queue.Count()==m)
            {
                if(flag==1)
                {
                    int res = queue.Peek();
                    while(queue.Count()>0)
                    {
                        target[queue.Dequeue()]='?';
                    }
                    return res;
                }
                else
                {
                    i = queue.Peek();
                    queue.Clear();
                    flag = 0;
                }
            }
            i++;
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