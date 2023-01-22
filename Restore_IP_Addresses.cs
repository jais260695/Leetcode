public class Solution {
    
    List<string> result = new List<string>();

    bool isValid(string s)
    {
        int zeroFront = 0;
        foreach(char ch in s)
        {
            if(ch=='0')
            {
                zeroFront++;
            }
            else{
                break;
            }
        }
        int val = Convert.ToInt32(s);
        if((zeroFront==1 && val!=0 || zeroFront>1)) return false;
        return  val>=0 && val<=255;
    }

    void Solve(int index, int remaining, string s, StringBuilder sb)
    {
        if(index==s.Length)
        {
            if(remaining==0)
            {
                result.Add(sb.ToString());               
            }
            return;
        }
        if(remaining<=0) return;
        StringBuilder sb1 = new StringBuilder();
        for(int i = index; i<s.Length;i++)
        {
            sb1.Append(s[i]);
            if(isValid(sb1.ToString()))
            {
                
                sb.Append(sb1.ToString());
                if(remaining>1)
                    sb.Append('.');
                Solve(i+1, remaining-1, s, sb);
                if(remaining>1)
                    sb.Remove(sb.Length - 1, 1);
                sb.Remove((sb.Length-sb1.Length) ,sb1.Length);
                
            }
            else
            {
                break;
            }
            
        }
    }
    public IList<string> RestoreIpAddresses(string s) {
        Solve(0,4,s, new StringBuilder());
        return result.ToList<string>();
    }
}