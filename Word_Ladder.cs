public class Solution {
    public bool Check(string s1, string s2)
    {
        if(s1.Length!=s2.Length) return false;
        int count = 0;
        for(int i=0;i<s1.Length;i++)
        {
            if(s1[i]!=s2[i])
            {
                count++;
                if(count==2) return false;
            }
        }
        return true;
    }
    public int LadderLength(string beginWord, string endWord, IList<string> wordList) {
        int n = wordList.Count();
        
        //Create Graph
        Dictionary<string,List<string>> adj = new Dictionary<string,List<string>>(); 
        Dictionary<string,bool> visited = new Dictionary<string,bool>(); 
        adj.Add(beginWord,new List<string>());
        visited.Add(beginWord,false);
        for(int i=1;i<=n;i++)
        {
            if(wordList[i-1]==beginWord) continue;
            adj.Add(wordList[i-1],new List<string>());
            visited.Add(wordList[i-1],false);
        }

        for(int i=0;i<n;i++)
        {
            if(Check(beginWord,wordList[i]))
            {
                adj[beginWord].Add(wordList[i]);
                adj[wordList[i]].Add(beginWord);
            }
        }
        
        for(int i=0;i<n-1;i++)
        {
            for(int j=i+1;j<n;j++)
            {
                if(Check(wordList[i],wordList[j]))
                {
                    adj[wordList[i]].Add(wordList[j]);
                    adj[wordList[j]].Add(wordList[i]);
                }
            }
        }
        
        //Breadth First Search
        Queue<string> queue = new Queue<string>();
        visited[beginWord] = true;
        queue.Enqueue(beginWord);
        int level = 0;
        while(queue.Count()>0)
        {
            int size = queue.Count();
            while(size>0)
            {
                string u = queue.Dequeue();
                if(u == endWord) return level+1;
                foreach(var v in adj[u])
                {
                    if(!visited[v])
                    {
                        visited[v] = true;
                        queue.Enqueue(v);
                    }
                }
                size--;
            }
            level++;
        }
        return 0;
        
    }
}