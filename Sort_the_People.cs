public class Solution {
    public string[] SortPeople(string[] names, int[] heights) {
        List<Tuple<string,int>> list = new List<Tuple<string,int>>();
        
        for(int i=0;i<names.Count();i++)
        {
            list.Add(new Tuple<string,int>(names[i],heights[i]));
        }
        
        list = list.OrderByDescending(a=>a.Item2).ToList();
        
        string[] result = new string[names.Count()];
        
        for(int i=0;i<names.Count();i++)
        {
            result[i] = list[i].Item1;
        }
        
        return result;
    }
}