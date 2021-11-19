/*
// Definition for a Node.
public class Node {
    public int val;
    public IList<Node> children;

    public Node() {}

    public Node(int _val) {
        val = _val;
    }

    public Node(int _val, IList<Node> _children) {
        val = _val;
        children = _children;
    }
}
*/

public class Solution {
    public IList<IList<int>> LevelOrder(Node root) {
        List<List<int>> res = new List<List<int>>();  
        if(root==null) return res.ToList<IList<int>>();
        Queue<Node> queue = new Queue<Node>();
        queue.Enqueue(root);        
        while(queue.Count()>0)
        {
            List<int> temp = new List<int>();
            int size = queue.Count();
            while(size>0)
            {
                Node t = queue.Dequeue();
                temp.Add(t.val);
                foreach(var node in t.children)
                {
                    queue.Enqueue(node);
                }
                size--;
            }
            res.Add(new List<int>(temp));
            
        }
        return res.ToList<IList<int>>();
    }
}