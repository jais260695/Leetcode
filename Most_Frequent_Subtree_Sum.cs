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
    Dictionary<int,int> sumToFreq = new Dictionary<int,int>();
    
    int maxFrequency = 0;
    int countFrequency = 0;
    
    public int Solve(TreeNode root)
    {
        int sum = root.val;
        
        if(root.left!=null)
        {
            sum+=Solve(root.left);
        }
        
        if(root.right!=null)
        {
            sum+=Solve(root.right);
        }
        
        if(!sumToFreq.ContainsKey(sum))
        {
            sumToFreq.Add(sum,0);
        }
        
        sumToFreq[sum]++;
        
        if(sumToFreq[sum]==maxFrequency)
        {
            countFrequency++;
        }
        
        if(sumToFreq[sum]>maxFrequency)
        {
            countFrequency = 1;
            
            maxFrequency = sumToFreq[sum];
        }
        
        return sum;
    }
    public int[] FindFrequentTreeSum(TreeNode root) {
        Solve(root);
        
        int[] ans = new int[countFrequency];
        
        int i = 0;
        
        foreach(KeyValuePair<int,int> kvp in sumToFreq)
        {
            if(kvp.Value==maxFrequency)
            {
                ans[i++] = kvp.Key;
                
                if(i==countFrequency) break;
            }
        }
        
        return ans;
    }
}