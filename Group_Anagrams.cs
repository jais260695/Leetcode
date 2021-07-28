public class Solution {
    public string sortString(string inputString)
    {
        char[] tempArray = inputString.ToCharArray();
        Array.Sort(tempArray);
        return new string(tempArray);
    }
    public IList<IList<string>> GroupAnagrams(string[] strs) {
        Dictionary<string,int> map = new Dictionary<string,int>();
        List<List<string>> result = new List<List<string>>();
        foreach(string s in strs)
        {
            string sorted = sortString(s);
            if(!map.ContainsKey(sorted))
            {
                map.Add(sorted,result.Count());
                result.Add(new List<string>());
            }
            result[map[sorted]].Add(s);
        }
        return result.ToList<IList<string>>();
    }
}