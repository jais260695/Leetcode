public class Solution {
    int[] parent;
    int Find(int index)
    {
        if(parent[index]==-1)
        {
            return index;
        }

        return parent[index] = Find(parent[index]);
    }

    void Union(int x, int y)
    {
        int u = Find(x);
        int v = Find(y);
        if(u<v)
        {
            parent[v] = u;
        }
        else
        {
            parent[u] = v;
        }
    }
    public string SmallestEquivalentString(string s1, string s2, string baseStr) {
        parent = new int[26];

        for(int i=0;i<26;i++)
        {
            parent[i] = -1;
        }

        int n = s1.Length;

        for(int i=0;i<n;i++)
        {
            
            
            int a = Find(s1[i]-'a');
            int b = Find(s2[i]-'a');
            if(a!=b)
            {
                Union(a,b);
            }
        }
        StringBuilder sb = new StringBuilder();

        foreach(char ch in baseStr)
        {
            int index = ch-'a';
            while(parent[index]!=-1)
            {
                index = parent[index];
            }

            sb.Append((char)(index+97));
        }

        return sb.ToString();
    }
}