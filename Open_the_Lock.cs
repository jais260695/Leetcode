public class Solution {

    public int OpenLock(string[] deadends, string target) {
        
        Dictionary<char,List<char>> adjList = new Dictionary<char,List<char>>();
        adjList.Add('0',new List<char>(){'9','1'});
        adjList.Add('1',new List<char>(){'0','2'});
        adjList.Add('2',new List<char>(){'1','3'});
        adjList.Add('3',new List<char>(){'2','4'});
        adjList.Add('4',new List<char>(){'3','5'});
        adjList.Add('5',new List<char>(){'4','6'});
        adjList.Add('6',new List<char>(){'5','7'});
        adjList.Add('7',new List<char>(){'6','8'});
        adjList.Add('8',new List<char>(){'7','9'});
        adjList.Add('9',new List<char>(){'8','0'});
        
        HashSet<string> state = new HashSet<string>();
        foreach(string deadend in deadends)
        {
            state.Add(deadend);
        }
        
        string start = "0000";
        if(state.Contains(start)) return -1;
        
        Queue<string> queue = new Queue<string>();
        queue.Enqueue("0000");
        queue.Enqueue(start);
        
        state.Add(start);        
        int result = 0;
        
        while(queue.Count() > 0)
        {
            int size = queue.Count();
            while(size>0)
            {
                string u = queue.Dequeue();
                if(u==target) return result;
                
                StringBuilder sb = new StringBuilder();
                for(int i=0;i<4;i++)
                {
                    foreach(char ch in adjList[u[i]])
                    {
                        sb.Append(u.Substring(0,i));
                        sb.Append(ch);
                        sb.Append(u.Substring(i+1));
                        
                        string v = sb.ToString();
                        
                        if(!state.Contains(v))
                        {
                            queue.Enqueue(v);
                            state.Add(v);
                        }
                        sb.Clear();
                    }
                }
                size--;
            }
            result++;
        }
        
        return -1;
    }
}