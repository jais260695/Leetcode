public class Solution {
    Dictionary<int,List<List<string>>> dp = new  Dictionary<int,List<List<string>>>();
    public IList<IList<string>> Solve(string s, int i, int n,bool[,] isPalindrome)
    {
        if(dp.ContainsKey(i)) return dp[i].ToList<IList<string>>();
        List<List<string>> result = new List<List<string>>();
        for(int j = i;j<n;j++)
        {
            if(isPalindrome[i,j])
            {
                if(j+1==n)
                {
                    result.Add(new List<string>(new List<string>(){s.Substring(i,j-i+1)}));
                }
                else
                {
                    foreach(List<string> t in Solve(s,j+1,n,isPalindrome))
                    {
                            List<string> temp = new List<string>(t);
                            temp.Insert(0,s.Substring(i,j-i+1));
                            result.Add(new List<string>(temp));
                    }
                }
            }
        }
        dp.Add(i,result);
        return result.ToList<IList<string>>();
    }
    public IList<IList<string>> Partition(string s) {
        int n = s.Length;
        bool[,] isPalindrome = new bool[n,n];
        for(int i=0;i<n-1;i++)
        {
            isPalindrome[i,i] = true;
            isPalindrome[i,i+1] = s[i]==s[i+1];
        }
        isPalindrome[n-1,n-1] = true;
        for(int k=2;k<n;k++)
        {
            for(int i=0,j=k;j<n;i++,j++)
            {
                isPalindrome[i,j] = (s[i]==s[j] && isPalindrome[i+1,j-1]);
            }
        }
        return Solve(s,0,s.Length,isPalindrome);
    }
}