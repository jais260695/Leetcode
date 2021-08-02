public class Solution {
    public bool IsInvalid(Dictionary<char,int> dictTemp, Dictionary<char,int> dict )
    {
        foreach(KeyValuePair<char,int> kvp in dictTemp)
        {
            if(dictTemp[kvp.Key]<dict[kvp.Key])
            {
                return true;
            }
        }
        return false;
    }
    public string MinWindow(string s, string t) {
        int n = s.Length;
        int m  = t.Length;
        Dictionary<char,int> dict = new Dictionary<char,int>();
        Dictionary<char,int> dictTemp = new Dictionary<char,int>();

        for(int i=0;i<m;i++)
        {
            if(!dict.ContainsKey(t[i])) 
            {
                dict.Add(t[i],0);
                dictTemp.Add(t[i],0);
            }
            dict[t[i]]++;
        }       
        for(int i=0;i<n;i++)
        {
            if(dictTemp.ContainsKey(s[i])) 
            {
                dictTemp[s[i]]++;
            }
        }

        if(IsInvalid(dictTemp,dict)) return "";
        
        int resLen = n;
        string result = s;
        
        int left = 0;
        int right = 0;
        
        for(int i=0;i<m;i++)
        {
            if(dictTemp.ContainsKey(t[i])) 
            {
                dictTemp[t[i]] = 0;
            }
        }  
        if(dictTemp.ContainsKey(s[0]))
            dictTemp[s[0]]++;
        while(left<=right && right<n)
        {
            if(IsInvalid(dictTemp,dict))
            {
                right++;
                if(right<n && dictTemp.ContainsKey(s[right]))
                {
                    dictTemp[s[right]]++;
                }
            }
            else
            {
                int currLen = right-left+1;
                if(resLen>currLen)
                {
                    resLen = currLen;
                    result = s.Substring(left,resLen);
                }
                if(dictTemp.ContainsKey(s[left]))
                {
                    dictTemp[s[left]]--;
                }
                left++;
            }
        }       
        return result;
    }
}