public class Solution {
    public bool Compare(string s1,string s2)
    {
        int i = 0;
        int j = 0;
        
        while(i<s1.Length && j < s2.Length)
        {
            if(s1[i]==s2[j])
            {
                i++;
                j++;
            }
            else
            {
                return s1[i]>s2[i];
                
            }
        }
        
        return s1.Length > s2.Length;
    }
    public IList<IList<string>> MostPopularCreator(string[] creators, string[] ids, int[] views) {
        Dictionary<string,long> dictViews = new  Dictionary<string,long>();
        Dictionary<string,int> dictViewsMax = new  Dictionary<string,int>();
        Dictionary<string,string> dictVideos = new  Dictionary<string,string>();
        
        int n = creators.Count();
        
        long maxViews = 0;
        
        for(int i=0;i<n;i++)
        {
            if(!dictViews.ContainsKey(creators[i]))
            {
                dictViews.Add(creators[i], 0);
                dictViewsMax.Add(creators[i], -1);
                dictVideos.Add(creators[i], string.Empty);
                
            }
            
            dictViews[creators[i]]+=views[i];
            
            if(views[i]>=dictViewsMax[creators[i]])
            {
                if(views[i]>dictViewsMax[creators[i]])
                {
                    dictVideos[creators[i]] = ids[i];
                }
                else
                {
                    if(Compare(dictVideos[creators[i]],ids[i]))
                    {
                        dictVideos[creators[i]] = ids[i];
                    }
                }
                dictViewsMax[creators[i]] = views[i];
            }
            
            maxViews = Math.Max(maxViews, dictViews[creators[i]]);
        }
        
        List<List<string>> result = new List<List<string>>();
        
        foreach(KeyValuePair<string,long> kvp in dictViews)
        {
           // Console.WriteLine(kvp.Key+" "+kvp.Value);
            if(kvp.Value==maxViews)
            {
                List<string> temp= new List<string>();
                temp.Add(kvp.Key);
                temp.Add(dictVideos[kvp.Key]);
                result.Add(temp);
            }
        }
        return result.ToList<IList<string>>();
    }
}