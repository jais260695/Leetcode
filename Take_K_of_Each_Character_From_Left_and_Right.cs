public class Solution {
    public int TakeCharacters(string s, int k) {
        int[] count = new int[3];

        foreach(char ch in s)
        {
            count[ch-'a']++;
        }

        if(count[0]<k || count[1]<k || count[2]<k) return -1;

        if(k==0) return 0;

        int i = 0;
        int j = 0;
        int result = 0;
        while(i<=j && j<s.Length)
        {
            while(j<s.Length)
            {
                int index = s[j]-'a';
                count[index]--;
                if(count[index]<k)
                {
                    result = Math.Max(result,j-i);
                    j++;
                    while(i<j)
                    {
                        count[s[i]-'a']++;
                        i++;
                        if(count[0]>=k && count[1]>=k && count[2]>=k){
                            break;
                        } 
                    }
                    break;
                }
                j++;
            }

            if(j==s.Length)
            {
                result = Math.Max(result,j-i);
            }
        }

        return s.Length-result;
    }
}