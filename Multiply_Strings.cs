public class Solution {
    public string AddStrings(string num1, string num2) {
        string ans ="";
        int c=0;
        int n1 = num1.Length;
        int n2 = num2.Length;
        int i=n1-1;
        int j=n2-1;
        while(i>=0 && j>=0)
        {
            int x = num1[i]-'0';
            int y = num2[j]-'0';
            
            int z = x + y + c;
            ans=(z%10) + ans;
            c = z/10;
            i--;
            j--;
        }
        while(i>=0)
        {
            int x = num1[i]-'0';
            int z = x + c;
            ans=(z%10) + ans;
            c = z/10;
            i--;
        }
        while(j>=0)
        {
            int y = num2[j]-'0';
            int z = y + c;
            ans=(z%10) + ans;
            c = z/10;
            j--;
        }
        return c>0?c+ans:ans;
    }
    public string Multiply(string num1, string num2) {
        if(num1=="0"||num2=="0") return "0";
        int n1 = num1.Length;
        int n2 = num2.Length;
        string ans = "0";
        for(int i=n1-1;i>=0;i--)
        {
            int p = num1[i]-'0';
            int c = 0;
            string temp="";
            for(int k=0;k<(n1-1-i);k++)
                temp+='0';
            for(int j=n2-1;j>=0;j--)
            {
                int q = num2[j]-'0';
                int z = p*q + c;
                temp=(z%10) + temp;
                c = z/10;
            }
            temp = c>0?c+temp:temp;
            ans = AddStrings(ans, temp);
        }
        return ans;
    }
}