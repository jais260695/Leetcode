public class Solution {
    public int MinSwaps(string s) {
        int  left = 0;
        int right = s.Length-1;
        int result = 0;
        int openCount = 0;
        int closeCount = 0;
        while(left<right)
        {
            if(s[left]=='[')
            {
                openCount++;
            }
            else
            {
                closeCount++;
            }
            if(closeCount>openCount)
            {
                while(left<right && s[right]==']')
                {
                    right--;
                }
                openCount++;
                closeCount--;
                result++;
            }            
             left++;   
        }
        return result;
    }
}