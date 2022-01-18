public class Solution {
    public bool CompareArrays(int[] arr1, int[] arr2)
    {
        for(int i=0;i<26;i++)
        {
            if(arr1[i]!=arr2[i]) return false;
        }
        return true;
    }
    public IList<int> FindAnagrams(string s, string p) {
        int[] countOfCharsInP = new int[26];
        foreach(char ch in p)
        {
            countOfCharsInP[ch-'a']++;
        }
        int n = p.Length;
        int m = s.Length;
        int i = 0;
        int j = n-1;
        List<int> result = new List<int>();
        int[] tempCount = new int[26];
        for(int k = i;k<=j && k<m;k++)
        {   
            tempCount[s[k]-'a']++;   
        }
        if(CompareArrays(countOfCharsInP,tempCount))
        {
            result.Add(i);
        }
        j++;
        i++;
        while(j<m)
        {
            tempCount[s[i-1]-'a']--; 
            tempCount[s[j]-'a']++; 
            if(CompareArrays(countOfCharsInP,tempCount))
            {
                result.Add(i);
            }
            i++;
            j++;
        }
        return result.ToList<int>();
    }
}