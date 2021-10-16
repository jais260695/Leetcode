public class Solution {
    public IList<IList<int>> GroupThePeople(int[] groupSizes) {
        Dictionary<int,List<int>> dict = new Dictionary<int,List<int>>();        
        List<List<int>> res = new List<List<int>>();
        int n = groupSizes.Count();
        for(int i = 0;i<n;i++)
        {
            if(!dict.ContainsKey(groupSizes[i]))
            {
                dict.Add(groupSizes[i],new List<int>());
                
            }
            dict[groupSizes[i]].Add(i);
            if(dict[groupSizes[i]].Count()==groupSizes[i])
            {
                res.Add(new List<int>(dict[groupSizes[i]]));
                dict[groupSizes[i]].Clear();
            }
        }   
        return res.ToList<IList<int>>();
    }
}