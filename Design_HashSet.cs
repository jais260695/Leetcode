public class MyHashSet {
    public int[] hashMap = new int[1000001];

    /** Initialize your data structure here. */
    public MyHashSet() {
        for(int i = 0;i<=1000000;i++)
        {
            hashMap[i] = -1;
        }
    }
    
    public void Add(int key) {
        hashMap[key] = 1;
    }
    
    public void Remove(int key) {
        hashMap[key] = -1;
    }
    
    /** Returns true if this set contains the specified element */
    public bool Contains(int key) {
        return hashMap[key]==-1?false:true;
    }
}

/**
 * Your MyHashSet object will be instantiated and called as such:
 * MyHashSet obj = new MyHashSet();
 * obj.Add(key);
 * obj.Remove(key);
 * bool param_3 = obj.Contains(key);
 */