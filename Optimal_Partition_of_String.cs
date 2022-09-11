public class Solution {
    public int PartitionString(string s) {
        int n = s.Length;
        
        int result = 0;
        
        int i = 0;
        int j = 0;
        
        int[] temp =  new int[26];
        
        while(i<=j && j<n)
        {
            result++;
            while(j<n)
            {
                if(temp[s[j]-'a']==0)
                {
                    temp[s[j]-'a']++;
                }
                else
                {
                    break;
                }
                
                j++;
            }
            
            i = j;
            
            temp = new int[26];
        }
        
        return result;
    }
}