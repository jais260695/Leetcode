public class Solution {
    public class Trie
    {
        public int count = 0;
        public Trie[] children = new Trie[26];
    }
    

    public void InsertIntoTrie(int index, int n, string word, Trie root)
    {
        if(index==n) return;

        if(root.children[word[index]-'a']==null)
        {
            root.children[word[index]-'a'] = new Trie();
        }
        
        root.children[word[index]-'a'].count++;
        
        InsertIntoTrie(index+1,n,word,root.children[word[index]-'a']);
        
        return;
    }
    
    public int FetchFromTrie(int index, int n, string word, Trie root)
    {
        if(index==n) return 0;
        
        return root.children[word[index]-'a'].count + FetchFromTrie(index+1,n,word,root.children[word[index]-'a']);
    }
    
    public int[] SumPrefixScores(string[] words) {
        Dictionary<string,int> map = new Dictionary<string,int>();
        
        Trie root = new Trie();
        
        foreach(string word in words)
        {
            InsertIntoTrie(0, word.Length, word, root);
        }
        
        int[] result = new int[words.Count()];
        int k =0;
        foreach(string word in words)
        {
            result[k] = FetchFromTrie(0, word.Length, word, root);
            k++;
        }
        
        return result;
    }
}