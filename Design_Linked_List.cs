public class MyLinkedList {

    public class Node
    {
        public int data;
        public Node next;
        public Node(int d)
        {
            data = d;
            next = null;
        }
    }
    
    public Node head;
    int size = 0;
    /** Initialize your data structure here. */
    public MyLinkedList() {
        head = null;
    }
    
    public void Print(Node temp)
    {
        while(temp!=null)
        {
            //Console.Write(temp.data+" ");
            temp = temp.next;
        }
        //Console.WriteLine();
    }
    
    /** Get the value of the index-th node in the linked list. If the index is invalid, return -1. */
    public int Get(int index) {
        //Console.Write("GET-"+size+" ");
        if(index>=size) 
        {
            //Console.WriteLine();
            return -1;
        }
        Node temp = head;
        int i = 0;
        while(i<index)
        {
            temp = temp.next;
            i++;
        }
        //Console.WriteLine(temp.data);
        return temp.data;
    }
    
    /** Add a node of value val before the first element of the linked list. After the insertion, the new node will be the first node of the linked list. */
    public void AddAtHead(int val) {
        Node node = new Node(val);
        node.next = head;
        head = node;
        size++;
        //Print(head);
    }
    
    /** Append a node of value val to the last element of the linked list. */
    public void AddAtTail(int val) {
        if(size==0)
        {
            AddAtHead(val);
            return;
        }
        Node node = new Node(val);
        Node temp = head;
        while(temp.next!=null)
        {
            temp = temp.next;
        }
        temp.next = node;
        size++;
        //Print(head);
    }
    
    /** Add a node of value val before the index-th node in the linked list. If index equals to the length of linked list, the node will be appended to the end of linked list. If index is greater than the length, the node will not be inserted. */
    public void AddAtIndex(int index, int val) {
        if(index>size) return;
        if(index==0)
        {
            AddAtHead(val);
            return;
        }
        Node node = new Node(val);
        Node temp = head;
        int i = 1;
        while(i<index)
        {
            temp = temp.next;
            i++;
        }
        Node t = temp.next;
        temp.next = node;
        node.next = t;
        size++;
        //Print(head);
    }
    
    /** Delete the index-th node in the linked list, if the index is valid. */
    public void DeleteAtIndex(int index) {
        //Console.Write("Delete-");
        if(index>=size)
        {
            //Console.WriteLine();
            return;
        }
        if(index==0)
        {
            head = head.next;
            size--;
            //Print(head);
            return;
        }
        Node temp = head;
        int i = 0;
        while(i<index-1)
        {
            temp = temp.next;
            i++;
        }
        Node del = temp.next;
        temp.next = del.next;
        del = null;
        size--;
        //Print(head);
    }
}

/**
 * Your MyLinkedList object will be instantiated and called as such:
 * MyLinkedList obj = new MyLinkedList();
 * int param_1 = obj.Get(index);
 * obj.AddAtHead(val);
 * obj.AddAtTail(val);
 * obj.AddAtIndex(index,val);
 * obj.DeleteAtIndex(index);
 */