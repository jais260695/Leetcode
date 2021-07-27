public class Solution {
    List<List<string>> result = new List<List<string>>();
    public bool isPalindrome(string s, int i, int j)
    {
        while(i<j && s[i]==s[j])
        {
            i++;
            j--;
        }
        
        return i>=j;
    }
    public void Solve(string s,int index, int n, List<string> ans)
    {
        if(index>=n) 
        {
            result.Add(new List<string>(ans));
            return;
        }
        for(int i = index;i<n;i++)
        {
            if(isPalindrome(s,index,i))
            {
                ans.Add(s.Substring(index,i-index+1));
                Solve(s,i+1,n,ans);
                ans.RemoveAt(ans.Count()-1);
            }
        }
    }
    public IList<IList<string>> Partition(string s) {
         Solve(s,0,s.Length,new List<string>());
        return result.ToList<IList<string>>();
    }
}