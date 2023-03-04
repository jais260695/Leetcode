public class Solution {
    int[] target;
    int[] source;
    bool CompareArr()
    {
        for(int i=0;i<26;i++)
        {
            if(target[i]!=source[i]) return false;
        }
        return true;
    }
    public int StrStr(string haystack, string needle) {    
        int n = needle.Length; 
        int m = haystack.Length; 

        if(n>m) return -1;

        target = new int[26];
        source = new int[26];

        for(int index=0;index<n;index++)
        {
            target[needle[index]-'a']++;
        }
         
        int i = 0;
        int j = n-1;

        for(int index=i;index<=j;index++)
        {
            source[haystack[index]-'a']++;
        }

        while(j<m)
        {
            if(CompareArr())
            { 
                if(haystack.Substring(i,n)==needle)
                    return i;
            }
            source[haystack[i]-'a']--;
            i++;
            j++;
            if(j==m) return -1;
            source[haystack[j]-'a']++;
        }

        return -1;
    }
}