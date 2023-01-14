public class Solution {
    List<int>[] children ;
    int[] result;
    int[] CountSubTreesUtil(int root,string labels)
    {
        Console.WriteLine(root);
        int[] currentCount = new int[26];
        result[root] = -1;
        foreach(int child in children[root])
        {
            if(result[child]!=-1)
            {
                int[] childCount = CountSubTreesUtil(child, labels);
                for(int i=0;i<26;i++)
                {
                    currentCount[i]+=childCount[i];
                }
            }
        }

        currentCount[labels[root]-'a']++;
        result[root] = currentCount[labels[root]-'a'];
        return currentCount;
    }
    public int[] CountSubTrees(int n, int[][] edges, string labels) {
        children = new List<int>[n];
        result = new int[n];
        for(int i=0;i<n;i++)
        {
            children[i] = new List<int>();
        }

        foreach(int[] edge in edges)
        {
            int from = edge[0];
            int to = edge[1];
            children[from].Add(to);
            children[to].Add(from);
        }

        CountSubTreesUtil(0, labels);

        return result;
    }
}