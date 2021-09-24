public class Solution {
    public IList<IList<string>> DisplayTable(IList<IList<string>> orders) {
        List<List<string>> result = new List<List<string>>();
        SortedDictionary<int, List<string>> mapping = new SortedDictionary<int, List<string>>();
        HashSet<string> dishes = new HashSet<string>();
        int n = orders.Count();
        for(int i=0;i<n;i++)
        {
            int table = Convert.ToInt32(orders[i][1]);
            string dish  = orders[i][2];
            dishes.Add(dish);
            if(!mapping.ContainsKey(table)) mapping.Add(table,new List<string>());
            mapping[table].Add(dish);
        }
        List<string> sortedDishes = dishes.OrderBy(x => x, StringComparer.Ordinal).ToList();
        sortedDishes.Insert(0,"Table");
        result.Add(sortedDishes);
        foreach(KeyValuePair<int, List<string>> map in mapping)
        {
            List<string> temp = new List<string>();
            temp.Add(map.Key.ToString());
            for(int i=1;i<sortedDishes.Count();i++)
            {
                temp.Add("0");
            }
            for(int i=0;i<map.Value.Count();i++)
            {
                int j = sortedDishes.IndexOf(map.Value[i]);
                temp[j] = (Convert.ToInt32(temp[j]) + 1).ToString();
            }
            result.Add(temp);
        }
        return result.ToList<IList<string>>();
    }
}