/*
// Definition for a Node.
public class Node {
    public int val;
    public Node left;
    public Node right;
    public Node next;

    public Node() {}

    public Node(int _val) {
        val = _val;
    }

    public Node(int _val, Node _left, Node _right, Node _next) {
        val = _val;
        left = _left;
        right = _right;
        next = _next;
    }
}
*/

public class Solution {
    public Node Connect(Node root) {
        if(root==null) return root;
        Queue<Node> queue = new Queue<Node>();
        queue.Enqueue(root);
        while(queue.Count()>0)
        {
            int size = queue.Count();
            Node rightNode = null;
            while(size>0)
            {
                Node currNode = queue.Dequeue();
                currNode.next = rightNode;
                if(currNode.right!=null) queue.Enqueue(currNode.right);
                if(currNode.left!=null) queue.Enqueue(currNode.left);
                rightNode = currNode;
                size--;
            }
        }
        return root;
    }
}