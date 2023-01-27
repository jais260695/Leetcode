public class Solution { 
    HashSet<string> map = new HashSet<string>();
    bool DFS(int u, string str, int n, int count)
    {
        if(u==n)
        {
            return count>1;
        }

        for(int j=u; j<n;j++)
        {
            if(map.Contains(str.Substring(u,j-u+1)))
            {
                if(DFS(j+1, str, n,count+1))
                {
                    return true;
                }
            }
        }

        return false;
    }
    public IList<string> FindAllConcatenatedWordsInADict(string[] words) {
        int n = words.Count();

        foreach(string word in words)
        {
            map.Add(word);
        }
        
        List<string> result = new List<string>();

        foreach(string word in words)
        {
            if(DFS(0, word, word.Length, 0))
            {
                result.Add(word);
            }
        }
        return result.ToList<string>();
    }
}