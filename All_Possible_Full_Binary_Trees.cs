/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    Dictionary<int, IList<TreeNode>> dp = new Dictionary<int, IList<TreeNode>>();
    public IList<TreeNode> AllPossibleFBT(int N) {
        List<TreeNode> res = new List<TreeNode>();
        if(N%2==0) return res.ToList<TreeNode>();
        
        if(N==1)
        {
            TreeNode temp = new TreeNode();
            res.Add(temp);
            return res.ToList<TreeNode>();
        }
        
        if(N==3)
        {
            TreeNode temp = new TreeNode();
            temp.left = new TreeNode();
            temp.right = new TreeNode();
            res.Add(temp);
            return res.ToList<TreeNode>();
        }
        
        if(dp.ContainsKey(N)) return dp[N];
        
        for(int k=1;k<N;k=k+2)
        {
            IList<TreeNode> leftResult = AllPossibleFBT(k);
            IList<TreeNode> rightResult = AllPossibleFBT(N-(k+1));
            for(int i=0;i<leftResult.Count();i++)
            {
                for(int j=0;j<rightResult.Count();j++)
                {
                    TreeNode temp = new TreeNode();
                    temp.left = leftResult[i];
                    temp.right = rightResult[j];
                    res.Add(temp);
                }
            }
        }
        dp.Add(N,res.ToList<TreeNode>());
        return res.ToList<TreeNode>();
    }
}