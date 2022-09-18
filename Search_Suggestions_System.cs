public class Solution {
    public class Trie
    {
        public List<int> list = new List<int>();
        public Trie[] children = new Trie[26];
        
        public Trie()
        {
            
        }
    }
    
    public void InsertToTrie(int index, string product, int n, int t, Trie root)
    {
        if(t==n) return;
        
        int i = product[t] - 'a';
        
        if(root.children[i]==null)
        {
            root.children[i] = new Trie();
        }
        
        root.children[i].list.Add(index); 
        
        InsertToTrie(index, product, n, t+1, root.children[i]);
    }
    
    
    List<List<string>> result = new List<List<string>>();
    
    public void SearchInTrie(string[] products, string searchWord, int n, int t, Trie root)
    {
        if(t==n) return;
        
        int i = searchWord[t] - 'a';
        
        List<string> temp = new List<string>();
        
        if(root != null && root.children[i]!=null)
        {
            for(int curr = 0; curr < 3 && curr < root.children[i].list.Count(); curr++)
            {
                temp.Add(products[root.children[i].list[curr]]);
            }
        }
        
        result.Add(temp);        
        
        SearchInTrie(products, searchWord, n, t+1, root==null ? null : root.children[i]);
    }
    
    public IList<IList<string>> SuggestedProducts(string[] products, string searchWord) {
        Array.Sort(products);
        
        Trie root = new Trie();
        
        int n = products.Count();
        
        for(int i=0;i<n;i++)
        {
            InsertToTrie(i, products[i], products[i].Count(), 0, root);
        }
        
        SearchInTrie(products, searchWord, searchWord.Length, 0, root);
        
        return result.ToList<IList<string>>();
    }
}