public class Solution {
    public int Maximum69Number (int num) {
        bool flag = true;
        List<int> l = new List<int>();
        while(num!=0)
        {
            l.Add(num%10);
            num = num/10;           
        }
        int n = l.Count();
        l.Reverse();
        int ans = 0;
        for(int i=0;i<n;i++)
        {
            if(flag && l[i]==6)
            {
               ans = ans+9;
                flag = false;
            }
            else
            {
                ans  = ans + l[i];
            }
            ans*=10;
        }
        return ans/10;
    }
}