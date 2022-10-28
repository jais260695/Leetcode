public class Solution {
    public bool IsPalindrome(int x) {
        if(x<0) return false;
        
        string temp = x.ToString();

        int i = 0;
        int j = temp.Length-1;
        
        while(i<=j)
        {
            if(temp[i]!=temp[j]) return false;
            i++;
            j--;
        }
        
        return true;
    }
}