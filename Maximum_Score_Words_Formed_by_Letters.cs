public class Solution {
    public Dictionary<string,int> dp = new Dictionary<string,int>();
    
    public string RemainingLetters(Dictionary<char,int> lettersCount)
    {
        StringBuilder sb = new StringBuilder();
        foreach(KeyValuePair<char,int> kvp in lettersCount)
        {
            for(int i = 0;i<kvp.Value;i++)
            {
                sb.Append(kvp.Key);
            }
        }
        return sb.ToString();
    }
    public bool ValidateWordCount(string word,Dictionary<char,int> lettersCount)
    {
        Dictionary<char,int> tempCount = new Dictionary<char,int>();
        foreach(char ch in word)
        {
            if(!tempCount.ContainsKey(ch))
            {
                tempCount.Add(ch,0);
            }
            tempCount[ch]++;
        }
        foreach(char ch in word)
        {
            if(!lettersCount.ContainsKey(ch) || lettersCount[ch]<tempCount[ch]) return false;
        }
        return true;
    }
    
    public Dictionary<char,int> UpdateLettersCount(string word,Dictionary<char,int> lettersCount)
    {
        Dictionary<char,int> res= new Dictionary<char,int>();
        foreach(KeyValuePair<char,int> kvp in lettersCount)
        {
            res.Add(kvp.Key,kvp.Value);
        }
        
        foreach(char ch in word)
        {
            res[ch]--;
        }
        
        return res;
    }
    
    public bool ValidateLettersCount(Dictionary<char,int> lettersCount)
    {
        foreach(KeyValuePair<char,int> kvp in lettersCount)
        {
            if(kvp.Value!=0) return false;
        }
        return true;
    }
    
    public int KnapSack(string[] words,Dictionary<string,int> wordsWeight,Dictionary<char,int> lettersCount,int currWord)
    {
        if(currWord==0 || ValidateLettersCount(lettersCount))
        {
            return 0;
        }
        string dpString = currWord + "-" +  RemainingLetters(lettersCount);
        if(dp.ContainsKey(dpString)) return dp[dpString];
        int ans = 0;
        if(ValidateWordCount(words[currWord-1],lettersCount))
        {
           ans =  Math.Max(
                    wordsWeight[words[currWord-1]] +
                    KnapSack(
                            words, 
                            wordsWeight, 
                            UpdateLettersCount(words[currWord-1], lettersCount), 
                            currWord-1
                    ),
                    KnapSack(words,wordsWeight,lettersCount,currWord-1)
                  );
        }
        else
        {
           ans =  KnapSack(words,wordsWeight,lettersCount,currWord-1);
        }
        dp.Add(dpString,ans);
        return ans;
    }
    
    public int GetWeight(string str,int[] score)
    {
        int res = 0;
        foreach(char ch in str)
        {
            res += score[ch-'a'];
        }
        return res;
    }
    
    public int MaxScoreWords(string[] words, char[] letters, int[] score) {
        Dictionary<char,int> lettersCount = new Dictionary<char,int>();
        Dictionary<string,int> wordsWeight = new Dictionary<string,int>();
        foreach(char ch in letters)
        {
            if(!lettersCount.ContainsKey(ch))
            {
                lettersCount.Add(ch,0);
            }
            lettersCount[ch]++;
        }
        foreach(string str in words)
        {
            if(!wordsWeight.ContainsKey(str))
            {
                wordsWeight.Add(str,GetWeight(str,score));
            }
        }
        
        return KnapSack(words,wordsWeight,lettersCount,words.Count());
        
    }
}