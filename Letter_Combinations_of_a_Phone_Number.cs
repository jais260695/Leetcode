public class Solution {
    Dictionary<char,List<char>> dict = new Dictionary<char,List<char>>();
    List<string> res = new List<string>();
    public void LetterCombinationsUtil(string digits, int n, string result, int index)
    {
        if(index==n)
        {
            res.Add(result);
            return;
        }
        
        foreach(char ch in dict[digits[index]])
        {
            LetterCombinationsUtil(digits,n, result+ch, index+1);
        }
        
        
    }
    public IList<string> LetterCombinations(string digits) {
        if(digits.Length==0) return res.ToList<string>();
        dict.Add('2',new List<char>(){'a','b','c'});
        dict.Add('3',new List<char>(){'d','e','f'});
        dict.Add('4',new List<char>(){'g','h','i'});
        dict.Add('5',new List<char>(){'j','k','l'});
        dict.Add('6',new List<char>(){'m','n','o'});
        dict.Add('7',new List<char>(){'p','q','r','s'});
        dict.Add('8',new List<char>(){'t','u','v'});
        dict.Add('9',new List<char>(){'w','x','y','z'});
        LetterCombinationsUtil(digits,digits.Length,string.Empty,0);
        return res.ToList<string>();
    }
}