public class Solution {
    
    public class ArrayComparer:IComparer<int[]>
    {
        public int Compare(int[] a, int[] b)
        {
            return a[1]-b[1];
        }
    }
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
    public int[] MaximizeXor(int[] nums, int[][] queries) {
        msb = 31;
        int n = nums.Count();  
        int m = queries.Count();
        Array.Sort(nums);
        int[][] dp = new int[m][];
        for(int i=0;i<m;i++)
        {
            dp[i] = new int[3];
            dp[i][0] = queries[i][0];
            dp[i][1] = queries[i][1];
            dp[i][2] = i;
        }
        Array.Sort(dp, new ArrayComparer());
        int minValue = nums.Min();        
        int[] result = new int[m];
        int j = 0;        
        for(int i=0;i<m;i++)
        {
            while(j<n && nums[j]<=dp[i][1])
            {
                InsertInTrie(nums[j]);
                j++;
            }
            
            result[dp[i][2]] = dp[i][1]<minValue ? -1 :  FindMaxPairXOR(dp[i][0]);
        }        
        return result;
    }
}