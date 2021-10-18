public class Solution {
    public string DestCity(IList<IList<string>> paths) {
        Dictionary<string, bool> dict = new Dictionary<string, bool>();
        
        foreach(var list in paths)
        {
        
                if(!dict.ContainsKey(list[0]))
                {
                    dict.Add(list[0],true);
                }
                else
                {
                    dict[list[0]] = true;
                }
                if(!dict.ContainsKey(list[1]))
                {
                    dict.Add(list[1],false);
                }
        }
        
        foreach(var list in dict)
        {
            if(list.Value==false)
                return list.Key;
        }
        return null;
    }
}