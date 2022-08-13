public class Solution {
    public IList<string> RemoveSubfolders(string[] folder) {
        Array.Sort(folder);
        int n = folder.Count();
        List<string> result = new List<string>();
        
        result.Add(folder[0]);
        for(int i=1;i<n;i++)
        {
            if(!folder[i].StartsWith((result[result.Count()-1] + "/" )) )
            {
                result.Add(folder[i]);
            }
        }
        
        return result.ToList<string>();
    }
}