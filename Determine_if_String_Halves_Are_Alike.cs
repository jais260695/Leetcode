public class Solution {
    public bool HalvesAreAlike(string s) {
        int n = s.Length;
        HashSet<char> vowels = new HashSet<char>(){'a','e','i','o','u','A','E','I','O','U'};
        int i = 0;
        int count = 0;
        while(i<(n/2))
        {
            if(vowels.Contains(s[i]))
            {
                count++;
            }
            i++;
        }

        while(i<n)
        {
            if(vowels.Contains(s[i]))
            {
                count--;
            }
            i++;
        }

        return count==0;
    }
}