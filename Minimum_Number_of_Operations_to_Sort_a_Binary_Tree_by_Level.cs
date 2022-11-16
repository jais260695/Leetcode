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
    public int MinimumOperations(TreeNode root) {
        Queue<TreeNode> queue = new Queue<TreeNode>();
        
        queue.Enqueue(root);
        
        int result = 0;
        
        while(queue.Count()>0)
        {
            int size = queue.Count();
            List<int> list = new List<int>();
            List<int> listTemp = new List<int>();
            
            while(size>0)
            {
                TreeNode temp = queue.Dequeue();
                list.Add(temp.val);
                listTemp.Add(temp.val);
                
                if(temp.left!=null)
                {
                    queue.Enqueue(temp.left);
                }
                if(temp.right!=null)
                {
                    queue.Enqueue(temp.right);
                }
                size--;
            }
            list.Sort();
            int i = 0;
            while(i<list.Count())
            {
                if(list[i]!=listTemp[i])
                {
                    result++;
                    int tempIndex = list.IndexOf(listTemp[i]);
                    int t = listTemp[tempIndex];
                    listTemp[tempIndex] = listTemp[i];
                    listTemp[i] = t;
                }
                else
                {
                    i++;
                }
            }
            
        }
        
        return result;
    }
}