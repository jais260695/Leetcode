public class Solution {
    public class Trie
    {
        public bool isVisited;
        public bool isEnd;
        public Trie[] children;
        public int count = 0;
        
        public Trie(bool isVisited, bool isEnd )
        {
            this.isVisited = isVisited;
            this.isEnd = isEnd;
        }
    }
    
    //int[,,] dp;
    
    void CreateTrie(Trie root, string t, int left, int right)
    {
        if(left>right)
        {
            root.count++;
            root.isEnd = true;
            return;
        }
        
        int key = t[left] - 'a';
        
        if(root.children[key].isVisited)
        {
            CreateTrie(root.children[key],t,left+1,right);
        }
        else{
            root.children[key].isVisited =  true;
            root.children[key].children = new Trie[26];
            for(int i=0;i<26;i++)
            {
                root.children[key].children[i] = new Trie(false,false); 
            }
            CreateTrie(root.children[key],t,left+1,right);
        }
        
    }
    
    
    int CheckTrie(Trie root, string s, int left, int right, int diff)
    {
        if(left>right)
        {
            
            if(diff==1)
            {
                return root.count;
            }
            return 0;
        }
        
        int key = s[left] - 'a';
        
        if(diff>1)
        {
            return 0;
        }
        
        //if(dp[left,right,diff]!=-1) return dp[left,right,diff];
        
        int result = 0;
        
        if(root.children[key].isVisited)
        {
           result+=CheckTrie(root.children[key],s,left+1,right,diff);
        }
        
        for(int i=0;i<26;i++)
        {
            if(i!=key && root.children[i].isVisited)
            {
                result+=CheckTrie(root.children[i],s,left+1,right,diff+1);
            }
        }
        //dp[left,right,diff] = result;
        return  result;
    }
    
    public int CountSubstrings(string s, string t) {
        int n = t.Length;
               
        Trie root = new Trie(true,false);
        root.children = new Trie[26];
        
        
        int result = 0;
        
        for(int i=0;i<26;i++)
        {
            root.children[i] = new Trie(false,false); 
        }
        
        for(int i=0;i<n;i++)
        {
            int l = 0;
            int r = i;
            while(r<n)
            {
                CreateTrie(root,t,l,r);               
                l++;
                r++;
            }
        }
        
        int m = s.Length;
        
        /*dp =  new int[m,m,2];
        
        for(int i=0;i<m;i++)
        {
            for(int j=0;j<m;j++)
            {
                dp[i,j,0] = -1;
                dp[i,j,1] = -1;
            }
        }*/
        
        for(int i=0;i<m;i++)
        {
            int l = 0;
            int r = i;

            while(r<m)
            {

                result +=  CheckTrie(root,s,l,r,0);
                l++;
                r++;                        
            }
        }
        
        return result;
    }
}