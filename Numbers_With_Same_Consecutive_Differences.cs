public class Solution {
    public int[] NumsSameConsecDiff(int n, int k) {
        Queue<Tuple<int,int>> queue = new Queue<Tuple<int,int>>(); 
        
        for(int i=1;i<10;i++)
        {
            queue.Enqueue(new Tuple<int,int>(i,i));
        }
        
        n--;
        
        
        while(n>0)
        {
            int size = queue.Count();
            while(size>0)
            {
                Tuple<int,int> t = queue.Dequeue();
                
                int val1 = t.Item1 - k;
                if(val1 >= 0)
                {
                    queue.Enqueue(new Tuple<int,int>(val1, val1 + 10 * t.Item2));
                }
                int val2 = t.Item1 + k;
                if(val2 < 10 && val1!=val2)
                {
                    queue.Enqueue(new Tuple<int,int>(t.Item1 + k, (t.Item1 + k) + 10 * t.Item2));
                }
                
                size--;
            }
            
            n--;
        }
        
        int[] result = new int[queue.Count()];
        int j = 0;
        while(queue.Count()>0)
        {
            Tuple<int,int> t = queue.Dequeue();
            
            result[j] = t.Item2;
            
            j++;
        }
        
        return result;
    }
}