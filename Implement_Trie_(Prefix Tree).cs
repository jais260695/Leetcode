public class Trie {

    /** Initialize your data structure here. */
    public class TrieDS {
        public bool isEnd;
        public TrieDS[] children = new TrieDS[26];
    
        /** Initialize your data structure here. */
        public TrieDS() {
            isEnd = false;
            for(int i=0;i<26;i++)
            {
                children[i] = null;
            }
        }
    }
    
    public TrieDS root;
    public Trie() {
        root =  new TrieDS();
    }
    
    /** Inserts a word into the trie. */
    public void Insert(string word) {
        TrieDS temp = root;
        int i=0;
        int j=0;
        for(;i<word.Length;i++)
        {
            j = word[i] - 'a';
            if(temp.children[j]==null)
                temp.children[j] = new TrieDS();
            temp = temp.children[j];
        }
        temp.isEnd = true;
    }
    
    /** Returns if the word is in the trie. */
    public bool Search(string word) {
        return SearchUtil(word,root,true);
    }
    
    public bool SearchUtil(string word, TrieDS root,bool isCompleteSearch)
    {
        int j = word[0] - 'a';
        
        if(root.children[j]==null) return false;
        
        if(word.Length==1)
        {
            return isCompleteSearch ? root.children[j].isEnd : true;
        }
        
        return SearchUtil(word.Substring(1),root.children[j],isCompleteSearch);
    }
    
    /** Returns if there is any word in the trie that starts with the given prefix. */
    public bool StartsWith(string prefix) {
        return SearchUtil(prefix,root,false);
    }
}

/**
 * Your Trie object will be instantiated and called as such:
 * Trie obj = new Trie();
 * obj.Insert(word);
 * bool param_2 = obj.Search(word);
 * bool param_3 = obj.StartsWith(prefix);
 */