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
    public TreeNode ReverseOddLevels(TreeNode root) {
        Queue<TreeNode> queue = new Queue<TreeNode>();
        int level = 0;
        queue.Enqueue(root);
        
        
        
        while(queue.Count()>0)
        {
            int size = queue.Count();
            List<TreeNode> oddLevel = new List<TreeNode>();
            
            while(size>0)
            {
                TreeNode t = queue.Dequeue();
                
                
                if(t.left != null)
                {
                    if(level%2==0)
                    {
                        oddLevel.Add(t.left);
                    }
                    else
                    {
                        queue.Enqueue(t.left);
                    }
                }
                
                if(t.right != null)
                {
                    if(level%2==0)
                    {
                        oddLevel.Add(t.right);
                    }
                    else
                    {
                        queue.Enqueue(t.right);
                    }
                }
                
                size--;
            }
            
            if(level%2==0)
            {  
                int i = 0;
                int j = oddLevel.Count()-1;

                while(i<j)
                {
                    int temp = oddLevel[i].val;
                    oddLevel[i].val = oddLevel[j].val;
                    oddLevel[j].val = temp;
                    i++;
                    j--;
                }
                
                for(i=0;i<oddLevel.Count();i++)
                {
                    queue.Enqueue(oddLevel[i]);
                }
                
            }           
            
            level++;
        }
        
        return root;
    }
}