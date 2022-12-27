public class Solution {
    public int ClosetTarget(string[] words, string target, int startIndex) {
        Dictionary<string,List<int>> dict = new Dictionary<string,List<int>>();
        int i = 0;
        string start = string.Empty;
        foreach(string word in words)
        {
            if(!dict.ContainsKey(word))
            {
                dict.Add(word,new List<int>());
            }
            dict[word].Add(i);
            i++;
        }
        
        if(!dict.ContainsKey(target))
        {
            return -1;
        }
        
        int n = words.Count();
        int result = n;
        foreach(int index in dict[target])
        {
            int temp =n;
            if(startIndex<=index)
            {
                temp = Math.Min(temp,index-startIndex);
                temp = Math.Min(temp,startIndex + n - index);
            }
            else
            {
                temp = Math.Min(temp,startIndex-index);
                temp = Math.Min(temp,index + n - startIndex);
            }
            result = Math.Min(result,temp);
        }
        
        return result;
    }
}