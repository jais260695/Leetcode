public class Solution {
    public string ComplexNumberMultiply(string a, string b) {
        string[] str1 = a.Split('+');
        string[] str2 = b.Split('+');
        int n1= Convert.ToInt32(str1[0]);
        int n2 = Convert.ToInt32(str2[0]);
        int real=(n1)*(n2);
        
        int num1 = 0;
        int len1 = str1[1].Length;
        if(str1[1][0]=='-')
        {
            num1 = (-1)*Int32.Parse(str1[1].Substring(1,len1-2));
        }
        else
        {
            num1 = Int32.Parse(str1[1].Substring(0,len1-1));
        }
        
        int num2 = 0;
        int len2 = str2[1].Length;
        if(str2[1][0]=='-')
        {
            num2 = (-1)*Int32.Parse(str2[1].Substring(1,len2-2));
        }
        else
        {
            num2 = Int32.Parse(str2[1].Substring(0,len2-1));
        }
        real-= (num1*num2);
        
        int complex = (n1*num2) + (n2*num1);
        
        return real +"+"+complex+"i";
    }
}