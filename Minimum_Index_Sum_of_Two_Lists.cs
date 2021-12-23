public class Solution {
    public string[] FindRestaurant(string[] list1, string[] list2) {
        Dictionary<string,int> dict = new Dictionary<string,int>();
        int i = 0;
        foreach(var item in list1)
        {
            dict.Add(item,i);
            i++;
        }
        
        List<string> list = new List<string>();
        i = 0;
        int count = int.MaxValue;
        foreach(var item in list2)
        {
            if(dict.ContainsKey(item))
            {
                if(dict[item]+i< count)
                {
                    list.Clear();
                    list.Add(item);
                    count = dict[item]+i;
                }
                else if(dict[item]+i == count)
                {
                    list.Add(item);
                }
            }
            i++;
        }
        return list.ToArray();
    }
}