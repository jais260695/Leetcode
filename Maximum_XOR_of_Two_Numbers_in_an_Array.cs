public class Solution {
    public class TrieNode
    {
        public TrieNode left;
        public TrieNode right;
        public TrieNode(TrieNode l=null, TrieNode right = null)
        {
            left = l;
            right = l;
        }
    }
    public TrieNode root = new TrieNode();
    public int msb = 0;
    public void InsertInTrie(int val)
    {
        TrieNode currNode = root;
        for(int i=msb;i>=0;i--)
        {
            int leftMostBit = (val>>i)&1;
            if(leftMostBit==0)
            {
                if(currNode.left==null)
                {
                    currNode.left = new TrieNode();
                }
                currNode = currNode.left;
            }
            else
            {
                if(currNode.right==null)
                {
                    currNode.right = new TrieNode();
                }
                currNode = currNode.right;
            }
        } 
    }
    public int FindMaxPairXOR(int val)
    {
        int res = 0;
        TrieNode currNode = root;
        for(int i=msb;i>=0;i--)
        {
            int leftMostBit = (val>>i)&1;
            if(leftMostBit==0)
            {
                if(currNode.right!=null)
                {
                    res = res|(1<<i);
                    currNode = currNode.right;
                }
                else
                {
                    currNode = currNode.left;
                }
            }
            else
            {
                if(currNode.left!=null)
                {
                    res = res|(1<<i);
                    currNode = currNode.left;
                }
                else
                {
                    currNode = currNode.right;
                }
            }
        }
        return res;
    }
    public int FindMaximumXOR(int[] nums) {        
        int maxValue = nums.Max();
        while(maxValue>0)
        {
            maxValue >>=1;
            msb++;
        }
        
        int n = nums.Count();
        
        for(int i=0;i<n;i++)
        {
            InsertInTrie(nums[i]);
        }
        
        int max = 0;
        
        for(int i=0;i<n;i++)
        {
            max = Math.Max(max,FindMaxPairXOR(nums[i]));
        }
        
        return max;
    }
}