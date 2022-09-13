public class Solution {
    public IList<string> BuildArray(int[] target, int n) {
        List<string> result = new List<string>();
        int j = 0;
        
        for(int i=1;i<=n && j< target.Count();i++)
        {
            if(target[j]==i)
            {
                result.Add("Push");
                j++;
            }
            else
            {
                result.Add("Push");
                result.Add("Pop");
            }
        }
        
        return result.ToList<string>();
    }
}