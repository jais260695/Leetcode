public class Solution {
    public IList<string> FizzBuzz(int n) {
        List<string> ans = new List<string>();
        
        for(int i =1;i<=n;i++)
        {
            
            if(i%3==0 && i%5==0)
            {
                ans.Add("FizzBuzz");
            }
            else if(i%3==0)
            {
                ans.Add("Fizz");
            }
            else if(i%5==0)
            {
                ans.Add("Buzz");
            }
            else
            {
                ans.Add(i.ToString());
            }
        }
        return ans;
    }
}