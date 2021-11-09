public class Solution {
    public int CalculateBitMask(string s){
        int mask = 0;
        foreach(char ch in s)
        {
            int val = ch-'a';
            mask = mask | (1<<val);
        }
        return mask;
    }
    public IList<int> FindNumOfValidWords(string[] words, string[] puzzles) {
        int m = puzzles.Count();
        int n = words.Count();
        Dictionary<int,int> bitMaskWordsMap = new Dictionary<int,int>();
        List<int> result = new List<int>();
        for(int i=0;i<n;i++)
        {
            int val = CalculateBitMask(words[i]);
            if(!bitMaskWordsMap.ContainsKey(val))
            {
                bitMaskWordsMap.Add(val,0);
            }
            bitMaskWordsMap[val]++;
        }
        for(int i=0;i<m;i++)
        {
            int firstLetter = 1<<(puzzles[i][0]-'a');
            int bitMaskPuzzle = CalculateBitMask(puzzles[i].Substring(1));
            int count = 0;
            for(int mask = bitMaskPuzzle;mask>0; mask = (mask-1)&bitMaskPuzzle)
            {
                int key = mask | firstLetter;
                if(bitMaskWordsMap.ContainsKey(key))
                    count+=bitMaskWordsMap[key];
            }
            if(bitMaskWordsMap.ContainsKey(firstLetter))
                count+=bitMaskWordsMap[firstLetter];
            result.Add(count);
        }
        return result;
    }
}