public class Solution {
    int[] count = new int[26];
    bool IsPossible(int k)
    {
        int sum = 0;
        int max = 0;

        for(int i=0;i<26;i++)
        {
            sum+=count[i];
            max = Math.Max(max,count[i]);
        }

        return (sum-max)<=k;
    }
    public int CharacterReplacement(string s, int k) {
        int n = s.Length;

        int result = 0;

        int i= -1;
        int j = 0;

        while(j<n)
        {
            count[s[j]-'A']++;

            if(IsPossible(k))
            {
                result = Math.Max(result,j-i);
            }
            else
            {
                while(i+1<n && !IsPossible(k))
                {
                    i++;
                    count[s[i]-'A']--;
                }
            }
            j++;
        }
        return result;
    }
}