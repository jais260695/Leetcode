public class Solution {
    public int MaxNumberOfBalloons(string text) {
        Dictionary<char,int> dict = new Dictionary<char,int>();
        dict.Add('b',0);
        dict.Add('a',0);
        dict.Add('l',0);
        dict.Add('o',0);
        dict.Add('n',0);
        
        foreach(char ch in text)
        {
            if(dict.ContainsKey(ch))
            {
                dict[ch]+=1;
            }
        }
        
        dict['l']/=2;
        dict['o']/=2;
        int result = int.MaxValue;
        foreach(KeyValuePair<char,int> keyV in dict)
        {
            result = Math.Min(result,keyV.Value);
        }
        
        return result==int.MaxValue?0:result;
    }
}