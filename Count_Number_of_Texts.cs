public class Solution {
    HashSet<string> charMap = new HashSet<string>();
    int[] dp;
    int mod = 1000000007;
    public int Solve(int index,string pressedKeys,int n)
    {
        if(index==n)
        {
            return 1;
        }
        if(dp[index]!=0) return dp[index];
        int count = 0;
        StringBuilder sb = new StringBuilder();
        for(int i=index;i<n;i++)
        {
            sb.Append(pressedKeys[i]);
            if(charMap.Contains(sb.ToString()))
            {
                
                count=(count+Solve(i+1,pressedKeys,n))%mod;
            }
            else
            {
                break;
            }
        }
        return dp[index] = count;
    }
    public int CountTexts(string pressedKeys) {
        int n = pressedKeys.Length;
        charMap.Add("2");
        charMap.Add("22");
        charMap.Add("222");
        charMap.Add("3");
        charMap.Add("33");
        charMap.Add("333");
        charMap.Add("4");
        charMap.Add("44");
        charMap.Add("444");
        charMap.Add("5");
        charMap.Add("55");
        charMap.Add("555");
        charMap.Add("6");
        charMap.Add("66");
        charMap.Add("666");
        charMap.Add("7");
        charMap.Add("77");
        charMap.Add("777");
        charMap.Add("7777");
        charMap.Add("8");
        charMap.Add("88");
        charMap.Add("888");
        charMap.Add("9");
        charMap.Add("99");
        charMap.Add("999");
        charMap.Add("9999");
        dp = new int[n];
        return Solve(0,pressedKeys,n);
    }
}