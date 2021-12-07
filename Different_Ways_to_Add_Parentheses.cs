public class Solution {
    public IList<int> DiffWaysToCompute(string input) {
        List<int> result = new List<int>();
        int n = input.Length;
        bool flag = false;
        for(int i=0;i<n;i++)
        {
            char ch = input[i];
            if(ch=='-' || ch=='+' || ch=='*')
            {
                flag = true;
                IList<int> left = DiffWaysToCompute(input.Substring(0,i));
                IList<int> right = DiffWaysToCompute(input.Substring(i+1));
                foreach(var l in left)
                {
                    foreach(var r in right)
                    {
                        if(ch=='*')
                            result.Add(l*r);
                        else if(ch=='+')
                            result.Add(l+r);
                        else
                            result.Add(l-r);
                    }
                }
                
            }
        }
        if(!flag)
        {
            result.Add(Convert.ToInt32(input));
        }
        return result.ToList<int>();
    }
}