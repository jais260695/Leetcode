public class RandomizedSet {
    HashSet<int> randomizedSet = new HashSet<int>();
    public RandomizedSet() {
        
    }
    
    public bool Insert(int val) {
        if(randomizedSet.Contains(val))
        {
            return false;
        }

        randomizedSet.Add(val);
        return true;
    }
    
    public bool Remove(int val) {
        if(!randomizedSet.Contains(val))
        {
            return false;
        }

        randomizedSet.Remove(val);
        return true;
    }
    
    public int GetRandom() {
        Random rnd = new Random();
        return randomizedSet.ElementAt(rnd.Next(randomizedSet.Count()));
    }
}

/**
 * Your RandomizedSet object will be instantiated and called as such:
 * RandomizedSet obj = new RandomizedSet();
 * bool param_1 = obj.Insert(val);
 * bool param_2 = obj.Remove(val);
 * int param_3 = obj.GetRandom();
 */