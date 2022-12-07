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
    public TreeNode CreateBinaryTree(int[][] descriptions) {
        
        Dictionary<int,TreeNode> map = new Dictionary<int,TreeNode>();
        HashSet<int> childSet = new HashSet<int>();

        int n = descriptions.Count();

        for(int i=0;i<n;i++)
        {
            int parent = descriptions[i][0];
            int child = descriptions[i][1];
            int isLeft = descriptions[i][2];
            childSet.Add(child);
            TreeNode parentTemp;

            if(map.ContainsKey(parent))
            {
                parentTemp = map[parent];
            }
            else
            {
                parentTemp = new TreeNode(parent);
                map.Add(parent,parentTemp);
            }

            TreeNode childTemp;

            if(map.ContainsKey(child))
            {
                childTemp = map[child];
                
            }
            else
            {
                childTemp = new TreeNode(child);
                map.Add(child,childTemp);
            }

            if(isLeft==1)
            {
                parentTemp.left = childTemp;
            }
            else
            {
                parentTemp.right = childTemp;
            }
        }

        foreach(KeyValuePair<int,TreeNode> nodes in map)
        {
            if(!childSet.Contains(nodes.Key))
            {
                return nodes.Value;
            }
        }

        return null;
    }
}