public class CombinationIterator {
    List<string> combinations = new List<string>();
    int current = 0;
    
    public void GenerateCombinations(string characters,int combinationLength, List<char> temp)
    {
        if(combinationLength==0)
        {
            combinations.Add(new string(temp.ToArray()));
            return;
        }
        
        for(int i=0;i<characters.Length;i++)
        {
            temp.Add(characters[i]);
            GenerateCombinations(characters.Substring(i+1),combinationLength-1, temp);
            temp.RemoveAt(temp.Count()-1);
        }
    }

    public CombinationIterator(string characters, int combinationLength) {
        GenerateCombinations(characters,combinationLength, new List<char>());
    }
    
    public string Next() {
        current++;
        return combinations[current-1];
    }
    
    public bool HasNext() {
        if(current<combinations.Count())
        {
            return true;
        }
        return false;
    }
}

/**
 * Your CombinationIterator object will be instantiated and called as such:
 * CombinationIterator obj = new CombinationIterator(characters, combinationLength);
 * string param_1 = obj.Next();
 * bool param_2 = obj.HasNext();
 */