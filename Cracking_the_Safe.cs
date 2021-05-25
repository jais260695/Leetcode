public class Solution {
    StringBuilder res = new StringBuilder();
    SortedList visited = new SortedList();
    public string CrackSafe(int n, int k) {
        StringBuilder str = new StringBuilder();
        for(int i=0;i<n-1;i++)
        {
            str.Append("0");
        }
        DFS(str.ToString(),k);
        return res.ToString()+str.ToString();
    }
    
    public void DFS(string strin, int k)
    {
        for(int i=0;i<k;i++)
        {
            string str = strin+i.ToString();
            if(!visited.ContainsKey(str))
            {
                visited.Add(str,"");
                DFS(str.Substring(1),k);
                res.Append(i);
            }
        }
    }
}