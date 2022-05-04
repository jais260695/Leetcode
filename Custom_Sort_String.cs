public class Solution {
    public string CustomSortString(string order, string s) {
        Dictionary<char,int> orderMap = new Dictionary<char,int>();
        int n = order.Length;
        int m = s.Length;
        int i = 0;
        for(;i<n;i++)
        {
            orderMap.Add(order[i],i);
        }
        
        for(int j=0;j<m;j++)
        {
            if(!orderMap.ContainsKey(s[j]))
            {
                orderMap.Add(s[j],i);
            }
        }
        
        char[] charArr = s.ToCharArray();
        
        Array.Sort<char>(charArr,delegate(char a, char b){
            return orderMap[a]-orderMap[b];
        });
        
        return new String(charArr);
    }
}